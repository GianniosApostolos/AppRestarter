namespace AppRestarter
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.selectProcessButton = new System.Windows.Forms.Button();
            this.processLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.titleProcessLabel = new System.Windows.Forms.Label();
            this.separatorPanel = new System.Windows.Forms.Panel();
            this.githubPictureBox = new System.Windows.Forms.PictureBox();
            this.rememberProcessCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTipMainForm = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.githubPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // selectProcessButton
            // 
            this.selectProcessButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.selectProcessButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(182)))), ((int)(((byte)(109)))));
            this.selectProcessButton.FlatAppearance.BorderSize = 0;
            this.selectProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectProcessButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectProcessButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(182)))), ((int)(((byte)(109)))));
            this.selectProcessButton.Location = new System.Drawing.Point(255, 35);
            this.selectProcessButton.Name = "selectProcessButton";
            this.selectProcessButton.Size = new System.Drawing.Size(95, 50);
            this.selectProcessButton.TabIndex = 0;
            this.selectProcessButton.Text = "Select Process";
            this.selectProcessButton.UseVisualStyleBackColor = false;
            this.selectProcessButton.Click += new System.EventHandler(this.selectProcessButton_Click);
            this.selectProcessButton.MouseEnter += new System.EventHandler(this.selectProcessButton_MouseEnter);
            this.selectProcessButton.MouseLeave += new System.EventHandler(this.selectProcessButton_MouseLeave);
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.processLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(182)))), ((int)(((byte)(109)))));
            this.processLabel.Location = new System.Drawing.Point(47, 72);
            this.processLabel.MaximumSize = new System.Drawing.Size(128, 72);
            this.processLabel.MinimumSize = new System.Drawing.Size(128, 15);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(128, 34);
            this.processLabel.TabIndex = 2;
            this.processLabel.Text = "Please select a process...";
            this.processLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.restartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(182)))), ((int)(((byte)(109)))));
            this.restartButton.FlatAppearance.BorderSize = 0;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(182)))), ((int)(((byte)(109)))));
            this.restartButton.Location = new System.Drawing.Point(255, 122);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(95, 50);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            this.restartButton.MouseEnter += new System.EventHandler(this.restartButton_MouseEnter);
            this.restartButton.MouseLeave += new System.EventHandler(this.restartButton_MouseLeave);
            // 
            // titleProcessLabel
            // 
            this.titleProcessLabel.AutoSize = true;
            this.titleProcessLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.titleProcessLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.titleProcessLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(182)))), ((int)(((byte)(109)))));
            this.titleProcessLabel.Location = new System.Drawing.Point(56, 35);
            this.titleProcessLabel.Name = "titleProcessLabel";
            this.titleProcessLabel.Size = new System.Drawing.Size(124, 20);
            this.titleProcessLabel.TabIndex = 1;
            this.titleProcessLabel.Text = "Selected Process";
            // 
            // separatorPanel
            // 
            this.separatorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(182)))), ((int)(((byte)(109)))));
            this.separatorPanel.Location = new System.Drawing.Point(212, -16);
            this.separatorPanel.Name = "separatorPanel";
            this.separatorPanel.Size = new System.Drawing.Size(5, 235);
            this.separatorPanel.TabIndex = 4;
            // 
            // githubPictureBox
            // 
            this.githubPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.githubPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("githubPictureBox.Image")));
            this.githubPictureBox.InitialImage = null;
            this.githubPictureBox.Location = new System.Drawing.Point(0, 161);
            this.githubPictureBox.Name = "githubPictureBox";
            this.githubPictureBox.Size = new System.Drawing.Size(33, 33);
            this.githubPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.githubPictureBox.TabIndex = 5;
            this.githubPictureBox.TabStop = false;
            this.githubPictureBox.Click += new System.EventHandler(this.githubPictureBox_Click);
            // 
            // rememberProcessCheckBox
            // 
            this.rememberProcessCheckBox.AutoSize = true;
            this.rememberProcessCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rememberProcessCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rememberProcessCheckBox.FlatAppearance.BorderSize = 0;
            this.rememberProcessCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.rememberProcessCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(182)))), ((int)(((byte)(109)))));
            this.rememberProcessCheckBox.Location = new System.Drawing.Point(186, 41);
            this.rememberProcessCheckBox.Name = "rememberProcessCheckBox";
            this.rememberProcessCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rememberProcessCheckBox.Size = new System.Drawing.Size(15, 14);
            this.rememberProcessCheckBox.TabIndex = 6;
            this.toolTipMainForm.SetToolTip(this.rememberProcessCheckBox, "Remember last selected process for future use.\r\nThe information is retrieved afte" +
        "r the application is restarted.\r\n");
            this.rememberProcessCheckBox.UseVisualStyleBackColor = true;
            this.rememberProcessCheckBox.CheckedChanged += new System.EventHandler(this.rememberProcessCheckBox_CheckedChanged);
            // 
            // toolTipMainForm
            // 
            this.toolTipMainForm.IsBalloon = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(384, 196);
            this.Controls.Add(this.rememberProcessCheckBox);
            this.Controls.Add(this.githubPictureBox);
            this.Controls.Add(this.separatorPanel);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.processLabel);
            this.Controls.Add(this.titleProcessLabel);
            this.Controls.Add(this.selectProcessButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 235);
            this.MinimumSize = new System.Drawing.Size(235, 130);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AppRestarter";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.githubPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectProcessButton;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label titleProcessLabel;
        private System.Windows.Forms.Panel separatorPanel;
        private System.Windows.Forms.PictureBox githubPictureBox;
        private System.Windows.Forms.CheckBox rememberProcessCheckBox;
        private System.Windows.Forms.ToolTip toolTipMainForm;
    }
}

