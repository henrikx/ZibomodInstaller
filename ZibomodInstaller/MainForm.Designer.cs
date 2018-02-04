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
            this.InstallButton = new System.Windows.Forms.Button();
            this.audioBirdCheck = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RGModCheckbox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RGModTextureOnly = new System.Windows.Forms.RadioButton();
            this.RGMod = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // xplaneDirTextBox
            // 
            this.xplaneDirTextBox.Location = new System.Drawing.Point(3, 25);
            this.xplaneDirTextBox.Name = "xplaneDirTextBox";
            this.xplaneDirTextBox.ReadOnly = true;
            this.xplaneDirTextBox.Size = new System.Drawing.Size(270, 20);
            this.xplaneDirTextBox.TabIndex = 0;
            this.xplaneDirTextBox.Text = "C:\\X-Plane\\X-Plane.exe";
            // 
            // InstallLog
            // 
            this.InstallLog.HideSelection = false;
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
            this.button1.Location = new System.Drawing.Point(275, 25);
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
            // InstallButton
            // 
            this.InstallButton.Location = new System.Drawing.Point(299, 347);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(75, 23);
            this.InstallButton.TabIndex = 3;
            this.InstallButton.Text = "Install";
            this.InstallButton.UseVisualStyleBackColor = true;
            this.InstallButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // audioBirdCheck
            // 
            this.audioBirdCheck.AutoSize = true;
            this.audioBirdCheck.Checked = true;
            this.audioBirdCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.audioBirdCheck.Location = new System.Drawing.Point(3, 65);
            this.audioBirdCheck.Name = "audioBirdCheck";
            this.audioBirdCheck.Size = new System.Drawing.Size(173, 17);
            this.audioBirdCheck.TabIndex = 4;
            this.audioBirdCheck.Text = "Install AudioBirdXP Sound Mod";
            this.audioBirdCheck.UseVisualStyleBackColor = true;
            this.audioBirdCheck.CheckedChanged += new System.EventHandler(this.audioBirdCheck_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RGModCheckbox);
            this.panel1.Controls.Add(this.audioBirdCheck);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.xplaneDirTextBox);
            this.panel1.Location = new System.Drawing.Point(24, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 108);
            this.panel1.TabIndex = 5;
            // 
            // RGModCheckbox
            // 
            this.RGModCheckbox.AutoSize = true;
            this.RGModCheckbox.Checked = true;
            this.RGModCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RGModCheckbox.Location = new System.Drawing.Point(3, 88);
            this.RGModCheckbox.Name = "RGModCheckbox";
            this.RGModCheckbox.Size = new System.Drawing.Size(105, 17);
            this.RGModCheckbox.TabIndex = 5;
            this.RGModCheckbox.Text = "RG Texture Mod";
            this.RGModCheckbox.UseVisualStyleBackColor = true;
            this.RGModCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RGModTextureOnly);
            this.panel2.Controls.Add(this.RGMod);
            this.panel2.Location = new System.Drawing.Point(12, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 60);
            this.panel2.TabIndex = 6;
            // 
            // RGModTextureOnly
            // 
            this.RGModTextureOnly.AutoSize = true;
            this.RGModTextureOnly.Checked = true;
            this.RGModTextureOnly.Location = new System.Drawing.Point(15, 26);
            this.RGModTextureOnly.Name = "RGModTextureOnly";
            this.RGModTextureOnly.Size = new System.Drawing.Size(149, 17);
            this.RGModTextureOnly.TabIndex = 1;
            this.RGModTextureOnly.TabStop = true;
            this.RGModTextureOnly.Text = "RG Mod with textures only";
            this.RGModTextureOnly.UseVisualStyleBackColor = true;
            // 
            // RGMod
            // 
            this.RGMod.AutoSize = true;
            this.RGMod.Location = new System.Drawing.Point(15, 3);
            this.RGMod.Name = "RGMod";
            this.RGMod.Size = new System.Drawing.Size(84, 17);
            this.RGMod.TabIndex = 0;
            this.RGMod.Text = "Full RG Mod";
            this.RGMod.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 399);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InstallLog);
            this.Controls.Add(this.InstallButton);
            this.Name = "MainForm";
            this.Text = "ZiboMod Install/Update Tool";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox xplaneDirTextBox;
        private System.Windows.Forms.RichTextBox InstallLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.CheckBox audioBirdCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox RGModCheckbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RGModTextureOnly;
        private System.Windows.Forms.RadioButton RGMod;
    }
}

