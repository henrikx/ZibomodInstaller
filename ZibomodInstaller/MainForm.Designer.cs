namespace ZibomodInstaller
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xplaneDirTextBox = new System.Windows.Forms.TextBox();
            this.InstallLog = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xplaneDirTextBox
            // 
            this.xplaneDirTextBox.Location = new System.Drawing.Point(24, 199);
            this.xplaneDirTextBox.Name = "xplaneDirTextBox";
            this.xplaneDirTextBox.ReadOnly = true;
            this.xplaneDirTextBox.Size = new System.Drawing.Size(270, 20);
            this.xplaneDirTextBox.TabIndex = 0;
            this.xplaneDirTextBox.Text = "C:\\X-Plane\\X-Plane.exe";
            // 
            // InstallLog
            // 
            this.InstallLog.Location = new System.Drawing.Point(24, 12);
            this.InstallLog.Name = "InstallLog";
            this.InstallLog.ReadOnly = true;
            this.InstallLog.Size = new System.Drawing.Size(363, 181);
            this.InstallLog.TabIndex = 1;
            this.InstallLog.Text = "Welcome to ZiboMod Installer! Please select your X-Plane installation path below " +
    "and hit Install to continue!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "X-Plane.exe|X-Plane.exe";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Install";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 399);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InstallLog);
            this.Controls.Add(this.xplaneDirTextBox);
            this.Name = "MainForm";
            this.Text = "ZiboMod Install/Update Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xplaneDirTextBox;
        private System.Windows.Forms.RichTextBox InstallLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}

