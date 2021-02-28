using System;
using System.Windows.Forms;
using System.Net; // Used for WebClient
using System.Diagnostics; // Process start to execute .reg

namespace Windows10FPS_fix
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            update_registry_button.Enabled = false; // Require user to tick checkmark, so they are aware it's their own risk.
        }

        private void update_registry_button_Click(object sender, EventArgs e) // When clicking, download file from my private GitHub gists', afterwards executing it without asking to (in Regedit).
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/brian8544/windows10_gamedvr_fix/main/registry_file/DVR_Disable.reg", @"DVR_Disable.reg");
            Process process = new Process();
            process.StartInfo.FileName = "regedit.exe";
            process.StartInfo.Arguments = "/s DVR_Disable.reg";
            process.Start();
            MessageBox.Show("Completed! Please restart your computer.");
            Application.Exit();
        }

        private void ownrisk_CheckedChanged(object sender, EventArgs e) // Require user to tick checkmark, so they are aware it's their own risk. 
        {                                                               
            if (ownrisk.Checked == true)                                // Button enabled
            {
                update_registry_button.Enabled = true;
            }

            if (ownrisk.Checked == false)                               // Button disabled
                update_registry_button.Enabled = false;
            }

        private void githublinklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/brian8544/windows10_gamedvr_fix");
        }
    }
}
