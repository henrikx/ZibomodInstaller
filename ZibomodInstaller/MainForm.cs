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
        }
        //Browse button
        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }
        //Install button
        private void button2_Click(object sender, EventArgs e)
        {

            Thread ZiboInstall = new Thread(InstallAction);
            InstallLog.AppendText("\nInstalling ZiboMod");
            ZiboInstall.Start();
        }
        private void InstallAction()
        {
            InstallActions.ZiboInstall();
        }
    }
}
