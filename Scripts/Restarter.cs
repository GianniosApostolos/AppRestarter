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

        public Restarter(string processPath)
        {
            this.processPath = processPath;

            if (String.IsNullOrEmpty(processPath))
            {
                processPath = lastProcessPath;
            }
            else
            {
                lastProcessPath = processPath;
            }

        }   

        public void SaveProcessPath()
        {

            if (processToRestart != null)
            {
                processPath = processToRestart.GetMainModuleFileName();
            }

            if (String.IsNullOrEmpty(processPath))
            {
                processPath = lastProcessPath;

                Properties.Settings.Default.lastSelectedProcessName = processToRestart.ProcessName;
                Properties.Settings.Default.lastSelectedProcessPath = processPath;
                
                Properties.Settings.Default.Save();
                
            }
            else
            {
                lastProcessPath = processPath;

                Properties.Settings.Default.lastSelectedProcessName = processToRestart.ProcessName;
                Properties.Settings.Default.lastSelectedProcessPath = processPath;
                
                Properties.Settings.Default.Save();

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

        private void StartProcess() 
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


        public void RestartProcess(string processName, string processPath) 
        {
            if (!String.IsNullOrWhiteSpace(processName) &&
                !String.IsNullOrWhiteSpace(processPath))
            {
                Task.Run(() =>
                {
                    // Kill all instances of the process
                    KillProcesses(processName);

                    // Restart the process
                    StartProcess(processPath);
                });
            }
        }

        private void KillProcesses(string processName)
        {

            if (!String.IsNullOrWhiteSpace(processName))
            {
                Process[] processes = Process.GetProcessesByName(processName);

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
        
        }

        private void StartProcess(string processPath)
        {
            if (!String.IsNullOrWhiteSpace(processPath))
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
}
