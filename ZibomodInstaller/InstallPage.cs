using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace ZibomodInstaller
{
    public partial class InstallPage : UserControl
    {
        public static InstallPage _InstallPage; //Make class accessible from other class
        public InstallPage()
        {
            InitializeComponent();
            _InstallPage = this;
        }
        //Update Progressbar function
        public void UpdateProgressbar(int percentage)
        {
            progressBar1.Value = percentage;
        }
        //On Installation Start
        public void InstallStart()
        {
            Thread InstallActionWorker = new Thread(InstallAction);
            InstallActions.UpdateUserStatus("Starting ZiboMod Install Operation...");
            InstallActionWorker.Start();

        }
        private void determineTaskLength()
        {
            //Determine task length here
        }
        private void InstallAction()
        {
            string xplaneDir = "";
            InstallActions.UpdateUserStatus("Preparing directory...");
            xplaneDir = Regex.Match(InstallOptionsPage._InstallOptionsPage.xplaneDirTextBox.Text, @"([\s\S]*?)(X-Plane\.exe)").Groups[1].Value;
            try
            {
                InstallActions.ZiboPrepareDir(xplaneDir); //Copy Laminar's 737
            }
            catch (DirectoryNotFoundException)
            {
                InstallActions.UpdateUserStatus("Could not find a valid X-Plane installation at this directory.");
                MessageBox.Show("Could not find a valid X-Plane installation at this directory.");
                InstallActions.CleanUp();
                goto AfterException;
            }
            InstallActions.UpdateUserStatus("Finding the latest Zibo Update...");
            string DownloadIDZibo = InstallActions.FindLatestFile("0B-tdl3VvPeOOYm12Wm80V04wdDQ"); //Get Drive ID of the latest zibo release
            InstallActions.UpdateUserStatus("Downloading ZiboMod...");
            try
            {
                InstallActions.ZiboDownload(DownloadIDZibo); //Download the selected file
                InstallActions.UpdateUserStatus("Extracting and installing ZiboMod...");
                InstallActions.ZiboExtract(xplaneDir); //Extract into xplane
            }
            catch (System.Net.WebException)
            {
                InstallActions.UpdateUserStatus("File couldn't be found or download quota exceeded. Ignoring...");
                Thread.Sleep(1500);
            }
            InstallActions.UpdateUserStatus("Done installing Zibomod.");
            //AudioBird
            if (InstallOptionsPage._InstallOptionsPage.audioBirdCheck.Checked)
            {
                InstallActions.UpdateUserStatus("Finding latest AudioBirdXP update...");
                string DownloadIDAudio = InstallActions.FindLatestFile("1IgWBmhgwKg6j4cjH3jSSO8KYfG2eurVZ");
                InstallActions.UpdateUserStatus("Downloading AudioBirdXP package...");
                InstallActions.AudioDownload(DownloadIDAudio);
                InstallActions.UpdateUserStatus("Installing into aircraft...");
                InstallActions.AudioExtract();
                InstallActions.AudioInstall(xplaneDir);
                //InstallLogAppendText("Installing into aircraft...");
                //InstallActions.AudioInstall(xplaneDir);
                InstallActions.UpdateUserStatus("Done installing AudioBirdXP Sound Mod.");
            }
            if (InstallOptionsPage._InstallOptionsPage.RGModCheckbox.Checked)
            {
                bool RGModTextureOnly = true; //Latest free RGMod isn't compatible with the latest zibo, so the user option is removed. Only textures are compatible.
                InstallActions.UpdateUserStatus("Finding latest RG update...");
                string DownloadIDRGMod = InstallActions.FindLatestRG();
                InstallActions.UpdateUserStatus("Downloading RG Mod...");
                InstallActions.RGDownload(DownloadIDRGMod);
                InstallActions.UpdateUserStatus("Installing RG Mod into aircraft...");
                InstallActions.RGExtract(RGModTextureOnly, xplaneDir);
                InstallActions.UpdateUserStatus("Done installing RG Mod texture mod.");
            }
            AfterException:
            InstallActions.UpdateUserStatus("Cleaning up...");
            InstallActions.CleanUp();
            AfterCleanup();
            InstallActions.UpdateUserStatus("All tasks have been completed. You may now close this program.");

        }
        private void AfterCleanup()
        {
            InstallActions.UpdateUserStatus("All tasks completed. Press close to exit.");
            closeButton.Enabled = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
