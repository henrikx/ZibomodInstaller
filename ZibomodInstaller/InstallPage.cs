﻿using System;
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
        public void ShowEULA()
        {
            InstallPage._InstallPage.Visible = false;
            DisplayEULA._DisplayEULA.Visible = true;
            while (DisplayEULA._DisplayEULA.Visible)
            {
                Thread.Sleep(150);
            }
            DisplayEULA._DisplayEULA.Visible = false;
            InstallPage._InstallPage.Visible = true;
        }
        private void InstallAction()
        {
            string xplaneDir = "";
            bool ziboModSkipped = false;
            bool audioBirdSkipped = false;
            bool texturemodSkipped = false;

            InstallActions.UpdateUserStatus("Preparing directory...");
            int taskLength = determineTaskLength();
            xplaneDir = Regex.Match(InstallOptionsPage._InstallOptionsPage.xplaneDirTextBox.Text, @"([\s\S]*?)(X-Plane\.exe)").Groups[1].Value;
            try
            {
                InstallActions.ZiboPrepareDir(xplaneDir); //Copy Laminar's 737
            }
            catch (DirectoryNotFoundException)
            {
                InstallActions.UpdateUserStatus("Could not find a valid X-Plane installation at this directory");
                MessageBox.Show("Could not find a valid X-Plane installation at this directory");
                goto AfterException;
            }
            InstallActions.UpdateUserStatus("Finding the latest Zibo Update...");
            string DownloadIDZibo = InstallActions.FindLatestFile("0B-tdl3VvPeOOYm12Wm80V04wdDQ"); //Get Drive ID of the latest zibo release. The string is the Drive ID for the zibomod download folder.
            if(DownloadIDZibo != InstallOptionsPage.installedZibo) //This compares the drive ID of the currently installed version to the newest known version
            {
                try
                {
                    InstallActions.UpdateUserStatus("Downloading ZiboMod... (1/" + Convert.ToString(taskLength) + ")");
                    InstallActions.ZiboDownload(DownloadIDZibo); //Download the selected file
                    InstallActions.UpdateUserStatus("Extracting and installing ZiboMod...(2/" + Convert.ToString(taskLength) + ")");
                    InstallActions.ZiboExtract(xplaneDir); //Extract into xplane
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
                try {
                    InstallActions.UpdateUserStatus("Finding latest AudioBirdXP update... (3/" + Convert.ToString(taskLength) + ")");
                    string DownloadIDAudio = InstallActions.FindLatestFile("1IgWBmhgwKg6j4cjH3jSSO8KYfG2eurVZ");
                    if (DownloadIDAudio != InstallOptionsPage.installedAudioB)
                    {
                        //ShowEULA(); Doesn't work yet. Freezes UI for some reason, even if it's in another thread than the Main UI thread.
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
                } catch (Exception ex)
                {
                    InstallActions.AppendLogText(ex.Message);
                    audioBirdSkipped = true;
                }
            }
            if (InstallOptionsPage._InstallOptionsPage.RGModCheckbox.Checked) //It is not necessary to reinstall the textures if zibomod isn't updated, however this causes a problem when the user already has the latest zibomod but has not installed the texturemod
            {
                if (!ziboModSkipped || !InstallOptionsPage.texturemodInstalled)
                {
                    try
                    {

                        bool RGModTextureOnly = true; //Latest free RGMod isn't compatible with the latest zibo, so the user option is removed. Only textures are compatible.
                        InstallActions.UpdateUserStatus("Finding latest texture mod update... (" + GetCurrentTaskTexturemod(1) + "/" + Convert.ToString(taskLength) + ")");
                        string DownloadIDRGMod = InstallActions.FindLatestRG();
                        InstallActions.UpdateUserStatus("Downloading texture mod... (" + GetCurrentTaskTexturemod(2) + "/" + Convert.ToString(taskLength) + ")");
                        InstallActions.RGDownload(DownloadIDRGMod);
                        InstallActions.UpdateUserStatus("Installing texture mod into aircraft... (" + GetCurrentTaskTexturemod(3) + "/" + Convert.ToString(taskLength) + ")");
                        InstallActions.RGExtract(RGModTextureOnly, xplaneDir);
                        InstallOptionsPage.texturemodInstalled = true;
                        InstallActions.UpdateUserStatus("Done installing RG Mod texture mod.");
                    }
                    catch (Exception ex)
                    {
                        InstallActions.AppendLogText(ex.Message);
                        texturemodSkipped = true;
                    }
                } else
                {
                    texturemodSkipped = true;
                }
            }
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