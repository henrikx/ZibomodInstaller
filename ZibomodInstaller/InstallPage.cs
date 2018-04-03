using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        //On Opened Page
        private void OnOpenedPage(object sender, EventArgs e)
        {

        }
    }
}
