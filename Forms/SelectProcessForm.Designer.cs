namespace AppRestarter.Forms
{
    partial class SelectProcessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.processListView = new System.Windows.Forms.ListView();
            this.processIdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // processListView
            // 
            this.processListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.processListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processIdColumn,
            this.processNameColumn});
            this.processListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(182)))), ((int)(((byte)(109)))));
            this.processListView.FullRowSelect = true;
            this.processListView.HideSelection = false;
            this.processListView.Location = new System.Drawing.Point(21, 12);
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(275, 350);
            this.processListView.TabIndex = 0;
            this.processListView.TileSize = new System.Drawing.Size(170, 30);
            this.processListView.UseCompatibleStateImageBehavior = false;
            this.processListView.View = System.Windows.Forms.View.Details;
            this.processListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.processListView_ColumnClick);
            this.processListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.processListView_MouseDoubleClick);
            // 
            // processIdColumn
            // 
            this.processIdColumn.Text = "ID";
            this.processIdColumn.Width = 100;
            // 
            // processNameColumn
            // 
            this.processNameColumn.Text = "Process";
            this.processNameColumn.Width = 530;
            // 
            // SelectProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(326, 373);
            this.Controls.Add(this.processListView);
            this.Name = "SelectProcessForm";
            this.ShowIcon = false;
            this.Text = "Select Process";
            this.Load += new System.EventHandler(this.SelectProcessForm_Load);
            this.Resize += new System.EventHandler(this.SelectProcessForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView processListView;
        private System.Windows.Forms.ColumnHeader processIdColumn;
        private System.Windows.Forms.ColumnHeader processNameColumn;
    }
}