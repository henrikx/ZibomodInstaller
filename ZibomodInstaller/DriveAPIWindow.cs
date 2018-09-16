using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZibomodInstaller
{
    public partial class DriveAPIWindow : Form
    {
        public DriveAPIWindow()
        {
            InitializeComponent();
            webBrowser1.Url = new System.Uri(@"https://accounts.google.com/o/oauth2/v2/auth?scope=https://www.googleapis.com/auth/drive+profile+email&response_type=code&state=security_token%3D138r5719ru3e1%26url%3Dhttps://oauth2.example.com/token&redirect_uri=https://oauth2.example.com&client_id=483328243011-p07ia8t70iec45qm818sh5ucjkkg98m7.apps.googleusercontent.com&access_type=offline");
            
        }
    }
}
