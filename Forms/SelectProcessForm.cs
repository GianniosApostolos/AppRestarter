using AppRestarter.Scripts;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AppRestarter.Forms
{
    public partial class SelectProcessForm : Form
    {

        private ListViewColumnSorter listViewColumnSorter;

        public SelectProcessForm()
        {
            InitializeComponent();

            listViewColumnSorter = new ListViewColumnSorter();

            this.processListView.ListViewItemSorter = listViewColumnSorter;
            listViewColumnSorter.SortColumn = 1;
            listViewColumnSorter.Order = SortOrder.Ascending;
        }

        private void SelectProcessForm_Load(object sender, EventArgs e)
        {
            processListView.Location = new Point(0, 0);

            this.Width = this.processListView.Width;
            
            this.Height= this.processListView.Height +50;
            
            this.MaximumSize = new Size(600+15, 800);
            
            processListView.MaximumSize = new Size(600, 800);
            

            //Populate the list view with the processes
            foreach (Process process in Process.GetProcesses())
            {
                ListViewItem item = new ListViewItem(process.Id.ToString());
            
                item.SubItems.Add(process.ProcessName);
                
                processListView.Items.Add(item);
            }

        }

        private void SelectProcessForm_Resize(object sender, EventArgs e)
        {
            processListView.Width = this.Width;
            
            processListView.Height = this.Height + 30;
        }

        public Process ProcessToReturn { get; private set; }
        private void processListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            if (processListView.SelectedItems.Count == 1)
            {
                
                ListViewItem listViewItem = processListView.SelectedItems[0];

                if (int.TryParse(listViewItem.SubItems[0].Text, out int processId))
                {
                    try
                    {
                        ProcessToReturn = Process.GetProcessById(processId);

                        this.Close();
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("The process is no longer running.");
                    }

                }
                else 
                {
                    MessageBox.Show("The process ID is not a number.");
                }

            }
            
        }

        private void processListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == listViewColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (listViewColumnSorter.Order == SortOrder.Ascending)
                {
                    listViewColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    listViewColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                listViewColumnSorter.SortColumn = e.Column;
                listViewColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.processListView.Sort();
        }
    }
}
