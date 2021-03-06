﻿using System;
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

namespace ZibomodInstaller
{
    public partial class InstallOptionsPage : UserControl
    {
        public static InstallOptionsPage _InstallOptionsPage;
        public InstallOptionsPage()
        {
            InitializeComponent();
            _InstallOptionsPage = this;
            LoadConfig();
        }

        //Load configuration
        string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ZiboModInstaller";
        public static string installedZibo = null;
        public static string installedAudioB = null;
        public static bool texturemodInstalled;
        private void LoadConfig()
        {
            try
            {
                if (!File.Exists(InstallActions.AppData + "\\data.xml"))
                {
                    InstallActions.InitConfig();
                }
                System.Xml.XmlDocument xmlConfigDoc = new System.Xml.XmlDocument();
                xmlConfigDoc.PreserveWhitespace = true;
                xmlConfigDoc.Load(AppData + "\\data.xml");
                xplaneDirTextBox.Text = xmlConfigDoc.SelectSingleNode("installer/configuration/xplanePath").InnerText;
                //audioBirdCheck.Checked = Convert.ToBoolean(xmlConfigDoc.SelectSingleNode("installer/configuration/audiobirdxp").InnerText);
                //RGModCheckbox.Checked = Convert.ToBoolean(xmlConfigDoc.SelectSingleNode("installer/configuration/texturemod").InnerText);
                installedZibo = xmlConfigDoc.SelectSingleNode("installer/data/ziboVer").InnerText;
                //installedAudioB = xmlConfigDoc.SelectSingleNode("installer/data/fmodVer").InnerText;
                dropdownbox.SelectedIndex = Convert.ToInt32(xmlConfigDoc.SelectSingleNode("installer/configuration/textureres").InnerText);
                //texturemodInstalled = Convert.ToBoolean(xmlConfigDoc.SelectSingleNode("installer/data/texturemodinstalled").InnerText);
                xmlConfigDoc.Save(AppData + "\\data.xml");

            } catch (Exception ex)
            {
                if (ex is NullReferenceException || ex is System.Xml.XmlException || ex is System.ArgumentOutOfRangeException)
                {
                    InstallActions.ResetConfig();
                    LoadConfig();
                    MessageBox.Show("Corrupt or old configuration detected. Configuration reset to default values.");
                    InstallActions.AppendLogText("Couldn't load configuration! Corrupt or old configuration detected. Configuration reset to default values.");
                    return;
                } if (ex is FileNotFoundException || ex is DirectoryNotFoundException)
                {
                    InstallActions.AppendLogText("The configuration or configuration folder couldn't be found.");
                    return;
                }
                throw ex;
            }
        }
        //Browse button
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xplaneDirTextBox.Text = openFileDialog1.FileName;
            }
        }
        //Install button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            InstallPage._InstallPage.Visible = true;
            InstallPage._InstallPage.InstallStart();
        }

        private void texturequestionmarkbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Due to licencing issues, this option is not yet available.");
        }
    }
}
