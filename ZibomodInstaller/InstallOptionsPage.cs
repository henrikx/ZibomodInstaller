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
        public static InstallOptionsPage _InstallOptionsPage;
        public InstallOptionsPage()
        {
            InitializeComponent();
            _InstallOptionsPage = this;
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
            InstallPage._InstallPage.Visible = true;
            InstallPage._InstallPage.InstallStart();
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
