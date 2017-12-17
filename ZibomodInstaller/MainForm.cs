using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        //Browse button
        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xplaneDirTextBox.Text = openFileDialog1.FileName;
            }
        }
        //Install button
        private void button2_Click(object sender, EventArgs e)
        {

            Thread InstallActionWorker = new Thread(InstallAction);
            InstallLog.AppendText("\nStarting ZiboMod Install Operation...\n");
            InstallActionWorker.Start();
        }
        private void InstallAction()
        {
            InstallLog.AppendText("\nPreparing directory...");
            string xplaneDir = Regex.Match(xplaneDirTextBox.Text, @"([\s\S]*?)(X-Plane\.exe)").Groups[1].Value;
            InstallActions.ZiboPrepareDir(xplaneDir); //Copy Laminar's 737
            InstallLogAppendText("Finding the latest Zibo Update..."); 
            string DownloadID = InstallActions.ZiboFindFile(); //Get Drive ID of the latest zibo release
            InstallLogAppendText("Downloading ZiboMod...");
            InstallActions.ZiboDownload(DownloadID); //Download the selected file
            InstallLogAppendText("Extracting and installing Zibomod...");
            InstallActions.ZiboExtract(xplaneDir); //Extract into xplane
            InstallLogAppendText("Cleaning up...");
            InstallActions.CleanUp();
            InstallLogAppendText("Done installing Zibomod");
        }
        public static void InstallLogAppendText(string appendString)
        {
            MainForm mainForm = new MainForm();
            mainForm.InstallLog.AppendText("\n" + appendString);
        }
    }
}
