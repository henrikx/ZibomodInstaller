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
        Thread InstallActionWorker;
        public void InstallStart()
        {
            InstallActionWorker = new Thread(InstallAction);
            this.EULApanel.Visible = false;
            InstallActions.UpdateUserStatus("Starting ZiboMod Install Operation...");
            MainForm._MainForm.closebutton.Enabled = false;
            InstallActions.SaveConfig();
            InstallActionWorker.Start();
        }
        private int determineTaskLength()
        {
            int taskLength = 2;
            if (InstallOptionsPage._InstallOptionsPage.audioBirdCheck.Checked) { taskLength+=3; } //There are three tasks for these two
            if (InstallOptionsPage._InstallOptionsPage.RGModCheckbox.Checked) { taskLength+=3; }
            return taskLength;
        }
        bool isEULAActive = false;
        public void ShowEULA(string EULAText)
        {
            try
            {
                isEULAActive = true;
                richTextBox1.Text = EULAText;
                EULApanel.Visible = true;
                MainForm._MainForm.closebutton.Enabled = true;
                while (isEULAActive)
                {
                    Thread.Sleep(250);
                }
                MainForm._MainForm.closebutton.Enabled = false;
                EULApanel.Visible = false;
            } catch (ThreadAbortException)
            {
                InstallActions.AppendLogText("InstallThread was aborted at EULAClose");
            }

        }
        private void EULAlabel_Click(object sender, EventArgs e)
        {
            acceptEULAbtn.Enabled = true;
        }

        private void acceptEULAbtn_Click(object sender, EventArgs e)
        {
            isEULAActive = false;
        }
        public static string xplaneDir = "";
        private void InstallAction()
        {
            bool ziboModSkipped = false;
            bool audioBirdSkipped = false;
            bool texturemodSkipped = false;

            int taskLength = determineTaskLength();
            xplaneDir = Regex.Match(InstallOptionsPage._InstallOptionsPage.xplaneDirTextBox.Text, @"([\s\S]*?)(X-Plane\.exe)").Groups[1].Value;
            InstallActions.UpdateUserStatus("Finding the latest Zibo Update...");
            string DownloadIDZibo = "";
            try
            {
                DownloadIDZibo = InstallActions.FindLatestGDriveFile("0B-tdl3VvPeOOYm12Wm80V04wdDQ", true); //Get Drive ID of the latest zibo release. The string is the Drive ID for the zibomod download folder.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Zibo has changed his means of distribution. Please wait for an update of this application or update it.");
                InstallActions.AppendLogText(ex.Message);
                ziboModSkipped = true;
            }
            if (DownloadIDZibo != InstallOptionsPage.installedZibo || InstallOptionsPage._InstallOptionsPage.forceInstallCheckbox.Checked) //This compares the drive ID of the currently installed version to the newest known version
            {
                try
                {
                    InstallActions.UpdateUserStatus("Downloading ZiboMod... (1/" + Convert.ToString(taskLength) + ")");
                    InstallActions.ZiboDownload(DownloadIDZibo); //Download the selected file
                    InstallActions.ZiboExtract(xplaneDir); //Extract into temp dir
                    try
                    {
                        InstallActions.UpdateUserStatus("Preparing directory...");
                        InstallActions.ZiboPrepareDir(xplaneDir); //Copy Laminar's 737
                    }
                    catch (DirectoryNotFoundException)
                    {
                        InstallActions.UpdateUserStatus("Could not find a valid X-Plane installation at this directory");
                        MessageBox.Show("Could not find a valid X-Plane installation at this directory");
                        goto AfterException;
                    }
                    InstallActions.UpdateUserStatus("Extracting and installing ZiboMod...(2/" + Convert.ToString(taskLength) + ")");
                    InstallActions.ZiboInstall(xplaneDir); // move files into xplane
                    InstallOptionsPage.installedZibo = DownloadIDZibo;
                    InstallOptionsPage.texturemodInstalled = false;
                    InstallActions.UpdateUserStatus("Done installing Zibomod");
                } catch (Exception ex)
                {
                    InstallActions.AppendLogText(ex.Message);
                    ziboModSkipped = true;
                }
            } else
            {
                ziboModSkipped = true;
                InstallActions.UpdateUserStatus("Zibomod is already up to date! Skipping...");
                Thread.Sleep(2000);
            }

            //AudioBird
            if (InstallOptionsPage._InstallOptionsPage.audioBirdCheck.Checked)
            {
                try
                {
                    InstallActions.UpdateUserStatus("Finding latest AudioBirdXP update... (3/" + Convert.ToString(taskLength) + ")");
                    string DownloadIDAudio = InstallActions.FindLatestGDriveFile("1Yv8vK6mjZ3OIf239xy34ECiOuX2-b1Iy", false);
                    if (DownloadIDAudio != InstallOptionsPage.installedAudioB || InstallOptionsPage._InstallOptionsPage.forceInstallCheckbox.Checked)
                    {
                        string AudioBirdEULA = "(C) 2017/2018 by audiobirdxp / o. schmidt\n" +
                                                "\n" +
                                                "================================\n" +
                                                "LICENSE / TERMS OF USE \n" +
                                                "================================\n" +
                                                "\n" +
                                                "\n" +
                                                "contact: audiobirdxp@gmail.com\n" +
                                                "\n" +
                                                "http://audiobirdxp.boards.net/\n" +
                                                "\n" +
                                                "This product is provided for free, but it is copyrighted and is shared with some rights reserved:\n" +
                                                "\n" +
                                                "By installing this sound pack, you acknowledge that it is not permitted to reupload any file in \n" +
                                                "the download to any other site or to modify, re-use, reverse-engineer or share any file in this pack. \n" +
                                                "This also includes any configuration files and scripts that are provided with this immersion pack. \n" +
                                                "\n" +
                                                "You install and use this pack at your own risk. Should you damage your software or hardware in any \n" +
                                                "way I will not be held responsible.\n" +
                                                "\n" +
                                                "Click the title above this textbox to unlock the install button."; //TODO: Put this in it's own file
                        ShowEULA(AudioBirdEULA);
                        InstallActions.UpdateUserStatus("Downloading AudioBirdXP package... (4/" + Convert.ToString(taskLength) + ")");
                        InstallActions.AudioDownload(DownloadIDAudio);
                        InstallActions.UpdateUserStatus("Installing FMOD into aircraft... (5/" + Convert.ToString(taskLength) + ")");
                        InstallActions.AudioExtract();
                        InstallActions.AudioInstall(xplaneDir);
                        InstallOptionsPage.installedAudioB = DownloadIDAudio;
                        InstallActions.UpdateUserStatus("Done installing AudioBirdXP Sound Mod.");
                    }
                    else
                    {
                        audioBirdSkipped = true;
                        InstallActions.UpdateUserStatus("AudioBirdXP is already up to date! Skipping...");
                        Thread.Sleep(2000);
                    }
                }
                catch (Exception ex)
                {
                    if (ex is ThreadAbortException) { return; };
                    MessageBox.Show("AXP has changed it's means of distribution. Please wait for an update of this application or update it.");
                    InstallActions.AppendLogText(ex.Message);
                    audioBirdSkipped = true;
                }
            }
            //This code is not intended for official release, due to licencing issues
            //
            //if (InstallOptionsPage._InstallOptionsPage.RGModCheckbox.Checked) //It is not necessary to reinstall the textures if zibomod isn't updated, however this causes a problem when the user already has the latest zibomod but has not installed the texturemod
            //{
            //    if (!ziboModSkipped || !InstallOptionsPage.texturemodInstalled || InstallOptionsPage._InstallOptionsPage.forceInstallCheckbox.Checked)
            //    {
            //        try
            //        {

            //            bool RGModTextureOnly = true; //Latest free RGMod isn't compatible with the latest zibo, so the user option is removed. Only textures are compatible.
            //            InstallActions.UpdateUserStatus("Finding latest texture mod update... (" + GetCurrentTaskTexturemod(1) + "/" + Convert.ToString(taskLength) + ")");
            //            string DownloadIDRGMod = InstallActions.FindLatestRG();
            //            InstallActions.UpdateUserStatus("Downloading texture mod... (" + GetCurrentTaskTexturemod(2) + "/" + Convert.ToString(taskLength) + ")");
            //            InstallActions.TextureDownload(DownloadIDRGMod);
            //            InstallActions.UpdateUserStatus("Installing texture mod into aircraft... (" + GetCurrentTaskTexturemod(3) + "/" + Convert.ToString(taskLength) + ")");
            //            InstallActions.RGExtract(RGModTextureOnly, xplaneDir);
            //            InstallOptionsPage.texturemodInstalled = true;
            //            InstallActions.UpdateUserStatus("Done installing RG Mod texture mod.");
            //        }
            //        catch (Exception ex)
            //        {
            //            InstallActions.AppendLogText(ex.Message);
            //            texturemodSkipped = true;
            //        }
            //    } else
            //    {
            //        texturemodSkipped = true;
            //    }
            //}
            InstallActions.SaveConfig();
            AfterException:
            InstallActions.UpdateUserStatus("Cleaning up...");
            InstallActions.CleanUp();
            AfterCleanup();
        }
        private void AfterCleanup()
        {
            UpdateProgressbar(100);
            InstallActions.UpdateUserStatus("All tasks completed. Press close to exit.");
            closeButton.Enabled = true;
            MainForm._MainForm.closebutton.Enabled = true;
        }
        private string GetCurrentTaskTexturemod(int sequencenmb)
        {
            string sequence = "";
            if (InstallOptionsPage._InstallOptionsPage.audioBirdCheck.Checked) { sequence = Convert.ToString(sequencenmb += 5); }
            else { sequence = Convert.ToString(sequencenmb += 2); }
            return sequence;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
