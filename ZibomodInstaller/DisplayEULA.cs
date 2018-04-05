using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ZibomodInstaller
{
    public partial class DisplayEULA : UserControl
    {
        public static DisplayEULA _DisplayEULA; //Make class accessible from other class
        public DisplayEULA()
        {
            InitializeComponent();
            _DisplayEULA = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            InstallButton.Enabled = true;
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            InstallPage._InstallPage.Visible = true;
        }
    }
}
