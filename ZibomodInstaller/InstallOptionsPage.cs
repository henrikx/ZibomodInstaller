using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using Ionic.Zip;
using System.Net;
using System.IO;
using System.Threading;

namespace ZibomodInstaller
{
    public partial class InstallOptionsPage : UserControl
    {
        public InstallOptionsPage()
        {
            InitializeComponent();
            InstallActions.InitConfig();
            LoadConfig();
        }

        //Load configuration
        string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ZiboModInstaller";
        private void LoadConfig()
        {

            System.Xml.XmlDocument xmlConfigDoc = new System.Xml.XmlDocument();
            xmlConfigDoc.PreserveWhitespace = true;
            xmlConfigDoc.Load(AppData + "\\data.xml");
            xplaneDirTextBox.Text = xmlConfigDoc.SelectSingleNode("installer/configuration/xplanePath").InnerText;
            xmlConfigDoc.Save(AppData + "\\data.xml");
        }


        //Browse button
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xplaneDirTextBox.Text = openFileDialog1.FileName;
                System.Xml.XmlDocument xmlConfigDoc = new System.Xml.XmlDocument();
                xmlConfigDoc.PreserveWhitespace = true;
                xmlConfigDoc.Load(AppData + "\\data.xml");
                xmlConfigDoc.SelectSingleNode("installer/configuration/xplanePath").InnerText = xplaneDirTextBox.Text;
                xmlConfigDoc.Save(AppData + "\\data.xml");
            }
        }
        //Install button
        private void button2_Click(object sender, EventArgs e)
        {
            Thread InstallActionWorker = new Thread(InstallAction);
            InstallLogAppendText("\nStarting ZiboMod Install Operation...\n");
            InstallActionWorker.Start();

        }
        private void InstallAction()
        {
            panel1.Enabled = false;
            InstallButton.Enabled = false;
            string xplaneDir = "";
            InstallLogAppendText("\nPreparing directory...");
            xplaneDir = Regex.Match(xplaneDirTextBox.Text, @"([\s\S]*?)(X-Plane\.exe)").Groups[1].Value;
            try
            {
                
                InstallActions.ZiboPrepareDir(xplaneDir); //Copy Laminar's 737
            }
            catch (DirectoryNotFoundException)
            {
                InstallLogAppendText("Could not find a valid X-Plane installation at this directory.");
                MessageBox.Show("Could not find a valid X-Plane installation at this directory.");
                InstallActions.CleanUp();
                goto AfterException;
            }
            InstallLogAppendText("Finding the latest Zibo Update...");
            string DownloadIDZibo = InstallActions.FindLatestFile("0B-tdl3VvPeOOYm12Wm80V04wdDQ"); //Get Drive ID of the latest zibo release
            InstallLogAppendText("Downloading ZiboMod...");
            try
            {
                InstallActions.ZiboDownload(DownloadIDZibo); //Download the selected file
                InstallLogAppendText("Extracting and installing ZiboMod...");
                InstallActions.ZiboExtract(xplaneDir); //Extract into xplane
            }
            catch (System.Net.WebException)
            {
                InstallLogAppendText("File couldn't be found or download quota exceeded. Ignoring...");
            }
            InstallLogAppendText("Done installing Zibomod.");
            //AudioBird
            if (audioBirdCheck.Checked)
            {
                InstallLogAppendText("\nAudioBirdXP Installation:\nFinding latest AudioBirdXP update...");
                string DownloadIDAudio = InstallActions.FindLatestFile("1IgWBmhgwKg6j4cjH3jSSO8KYfG2eurVZ");
                InstallLogAppendText("Downloading AudioBirdXP package...");
                InstallActions.AudioDownload(DownloadIDAudio);
                InstallLogAppendText("Installing into aircraft...");
                InstallActions.AudioExtract();
                InstallActions.AudioInstall(xplaneDir);
                //InstallLogAppendText("Installing into aircraft...");
                //InstallActions.AudioInstall(xplaneDir);
                InstallLogAppendText("Done installing AudioBirdXP Sound Mod.");
            }
            if (RGModCheckbox.Checked)
            {
                bool RGModTextureOnly = true; //Latest free RGMod isn't compatible with the latest zibo, so the user option is removed. Only textures are compatible.
                InstallLogAppendText("\nRG Mod Installation:\nFinding latest RG update...");
                string DownloadIDRGMod = InstallActions.FindLatestRG();
                InstallLogAppendText("Downloading RG Mod...");
                InstallActions.RGDownload(DownloadIDRGMod);
                InstallLogAppendText("Installing RG Mod into aircraft...");
                InstallActions.RGExtract(RGModTextureOnly, xplaneDir);
                InstallLogAppendText("Done installing RG Mod texture mod.");
            }
            AfterException:
            InstallLogAppendText("Cleaning up...");
            InstallActions.CleanUp();
            AfterCleanup();
            InstallLogAppendText("All tasks have been completed. You may now close this program.");

        }
        private void InstallLogAppendText(string appendString)
        {
            InstallLog.AppendText("\n" + appendString);
            InstallLog.Select(InstallLog.TextLength, 0);
            InstallLog.ScrollToCaret();
        }
        private void AfterCleanup()
        {
            panel1.Enabled = false;
            InstallButton.Enabled = true;
            InstallButton.Text = "Close";
        }

        private void audioBirdCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!audioBirdCheck.Checked)
            {
                MessageBox.Show("It is recommended to install the sound mod in combination with ZiboMod. The sound mod is a significant improvement over the default sound model."); //Subject for redesign
            }
        }
    }
}
