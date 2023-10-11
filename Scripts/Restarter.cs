using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AppRestarter.Scripts
{
    internal static class Extensions
    {
        [DllImport("Kernel32.dll")]
        private static extern bool QueryFullProcessImageName([In] IntPtr hProcess, [In] uint dwFlags, [Out] StringBuilder lpExeName, [In, Out] ref uint lpdwSize);

        public static string GetMainModuleFileName(this Process process, int buffer = 1024)
        {
            var fileNameBuilder = new StringBuilder(buffer);
            uint bufferLength = (uint)fileNameBuilder.Capacity + 1;
            return QueryFullProcessImageName(process.Handle, 0, fileNameBuilder, ref bufferLength) ?
                fileNameBuilder.ToString() :
                null;
        }
    }

    internal class Restarter
    {
        Process processToRestart;
        
        string processPath;

        static string lastProcessPath;

        public Restarter(Process processToRestart)
        {
            this.processToRestart = processToRestart;

            if (processToRestart != null)
            {
            
                processPath = processToRestart.GetMainModuleFileName();
            
            }

            if (String.IsNullOrEmpty(processPath))
            {
                processPath = lastProcessPath;
            }else
            {
                lastProcessPath = processPath;
            }

        }

        private void KillProcesses()
        {
            Process[] processes = Process.GetProcessesByName(processToRestart.ProcessName);

            foreach (var process in processes)
            {

                try
                {
                    if (!process.HasExited)
                    {
                        process.CloseMainWindow();

                        if (!process.WaitForExit(10))
                        {
                            process.Kill();

                            process.WaitForExit();

                        }
                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine($"Failed to kill process: {e.Message}");

                }

            }

        }

        public void RestartProcess()
        {

            if (processToRestart != null)
            {
                Task.Run(() =>
                {
                    // Kill all instances of the process
                    KillProcesses();

                    // Restart the process
                    StartProcess();
                });
            }

        }

        public void StartProcess() 
        {

            try
            {

                Process.Start(processPath);

                lastProcessPath = processPath;

            }
            catch (Exception e)
            {

                Console.WriteLine($"Failed to start process: {e.Message}");

            }

        }

    }
}
