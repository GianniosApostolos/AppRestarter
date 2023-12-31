﻿using AppRestarter.Forms;
using AppRestarter.Scripts;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AppRestarter
{
    public partial class MainForm : Form
    {
        KeyboardHook keyboardHook = new KeyboardHook();
        public MainForm()
        {
            InitializeComponent();

            separatorPanel.BackColor = Color.FromArgb(25, 99, 182, 109);

            InitializeSavedValues();

            keyboardHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(restartButton_Click);
            
            // register the control + End combination as hot key.
            keyboardHook.RegisterHotKey(Enums.ModifierKeys.Control, Keys.End);
        }


        string loadedProcessPath;
        string loadedProcessName;
        bool hasFinihsedLoadingSavedValues = false;
        private void InitializeSavedValues() 
        {
            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.lastSelectedProcessPath.ToString()) &&
                !String.IsNullOrWhiteSpace(Properties.Settings.Default.lastSelectedProcessName.ToString()))
            {

                rememberProcessCheckBox.Checked = true;

                loadedProcessPath = Properties.Settings.Default.lastSelectedProcessPath.ToString();
                loadedProcessName = Properties.Settings.Default.lastSelectedProcessName.ToString();

                processLabel.Text = loadedProcessName;
                processLabel.ForeColor = Color.FromArgb(255, 188, 140, 255);
            }
            else 
            {
                rememberProcessCheckBox.Checked = false;
                rememberProcessCheckBox.Enabled = false;
                rememberProcessCheckBox.Visible = false;

                loadedProcessPath = null;
                loadedProcessName = null;
            }
            hasFinihsedLoadingSavedValues = true;
        }
        private void selectProcessButton_Click(object sender, EventArgs e)
        {
            SelectProcessForm selectProcessForm = new SelectProcessForm();

            selectProcessForm.FormClosed += SelectProcessForm_FormClosed;

            selectProcessForm.ShowDialog();

        }

        Process previousProcess;
        Process selectedProcess;
        private void SelectProcessForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            SelectProcessForm selectProcessForm = (SelectProcessForm)sender;

            selectedProcess = selectProcessForm.ProcessToReturn;

            if (selectedProcess != null)
            {
                previousProcess = selectedProcess;
                processLabel.Text = selectedProcess.ProcessName;
                processLabel.ForeColor = Color.FromArgb(255, 188, 140, 255);

                rememberProcessCheckBox.Enabled = true;
                rememberProcessCheckBox.Visible = true;
            }
            else if (selectedProcess == null && previousProcess != null)
            {
                processLabel.Text = previousProcess.ProcessName;
                processLabel.ForeColor = Color.FromArgb(255, 188, 140, 255);
            }

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            if (selectedProcess != null)
            {
                Restarter restarter = new Restarter(selectedProcess);
                restarter.RestartProcess();
            }
            else if (previousProcess != null)
            {
                Restarter restarter = new Restarter(previousProcess);
                restarter.RestartProcess();
            }

            if (selectedProcess == null && previousProcess == null) 
            {
                Restarter restarter = new Restarter(loadedProcessPath);
                restarter.RestartProcess(loadedProcessName,loadedProcessPath);
            }

        }


        private void selectProcessButton_MouseEnter(object sender, EventArgs e)
        {
            this.selectProcessButton.FlatAppearance.BorderSize = 1;
        }

        private void selectProcessButton_MouseLeave(object sender, EventArgs e)
        {
            this.selectProcessButton.FlatAppearance.BorderSize = 0;
        }

        private void restartButton_MouseEnter(object sender, EventArgs e)
        {
            this.restartButton.FlatAppearance.BorderSize = 1;
        }

        private void restartButton_MouseLeave(object sender, EventArgs e)
        {
            this.restartButton.FlatAppearance.BorderSize = 0;
        }

        private void githubPictureBox_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("You are about to be redirected to: " +
                                "\n\nhttps://github.com/GianniosApostolos/AppRestarter/releases" +
                                "\n\nAre you sure?",
                                "Attempting to open external link",
                                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Process.Start("https://github.com/GianniosApostolos/AppRestarter/releases");
            }

        }

        private void rememberProcessCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (selectedProcess != null && rememberProcessCheckBox.Checked) 
            {
                Restarter restarter = new Restarter(selectedProcess);
                restarter.SaveProcessPath();
            }
            else
            {
                if (hasFinihsedLoadingSavedValues) { 
                    Properties.Settings.Default.lastSelectedProcessName = "";
                    Properties.Settings.Default.lastSelectedProcessPath = "";
                    Properties.Settings.Default.Save();
                }
            }

        }


        // This method is triggered when the form is resized by the user.
        // Depending on the size of the form, it will show or hide some of the controls.
        // This is done to make sure that the form looks good and retains some usability in all sizes.
        private void MainForm_Resize(object sender, EventArgs e)
        {

            if (this.Height <= this.MinimumSize.Height)
            {

                if (this.Width <= this.MinimumSize.Width)
                {
                    // Will only show the restart button
                    // and hide the rest.
                    // This case occurs when the user has resized the form towards
                    // its top left corner.
                    this.titleProcessLabel.Visible = false;
                    this.rememberProcessCheckBox.Visible = false;
                    this.processLabel.Visible = false;
                    this.githubPictureBox.Visible = false;
                    this.selectProcessButton.Visible = false;
                    this.restartButton.Location = new Point(55, 35);

                }
                else
                {
                    // Will show the restart button and the select process button
                    // and hide the rest.
                    // This case occurs when the user has resized the form towards
                    // its top but has also dragged it to the right.
                    this.titleProcessLabel.Visible = false;
                    this.rememberProcessCheckBox.Visible = false;
                    this.processLabel.Visible = false;
                    this.githubPictureBox.Visible = false;
                    this.selectProcessButton.Visible = true;
                    this.selectProcessButton.Location = new Point(55, 35);
                    this.restartButton.Location = new Point(255, 35);

                }

            }
            else
            {
                if (this.Width <= this.MinimumSize.Width)
                {
                    // Will only show the restart button and the github picture box
                    // and hide the rest.
                    // This case occurs when the user has resized the form towards
                    // the left side but hasn't resized it too much upwards.
                    this.titleProcessLabel.Visible = false;
                    this.rememberProcessCheckBox.Visible = false;
                    this.processLabel.Visible = false;
                    this.githubPictureBox.Visible = true;
                    this.selectProcessButton.Visible = false;
                    this.restartButton.Location = new Point(55, 35);

                }
                else
                {
                    // Will show all controls
                    // This DEFAULT case occurs when no form resize threshold has been reached.
                    this.selectProcessButton.Visible = true;
                    this.restartButton.Location = new Point(255, 122);
                    this.selectProcessButton.Location = new Point(255, 35);
                    this.titleProcessLabel.Visible = true;
                    this.rememberProcessCheckBox.Visible = true;
                    this.processLabel.Visible = true;
                    this.githubPictureBox.Visible = true;
                }

            }

        }

    }

}
