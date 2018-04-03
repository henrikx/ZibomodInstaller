namespace ZibomodInstaller
{
    partial class InstallOptionsPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.RGModCheckbox = new System.Windows.Forms.CheckBox();
            this.audioBirdCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.xplaneDirTextBox = new System.Windows.Forms.TextBox();
            this.InstallLog = new System.Windows.Forms.RichTextBox();
            this.InstallButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RGModCheckbox);
            this.panel1.Controls.Add(this.audioBirdCheck);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.xplaneDirTextBox);
            this.panel1.Location = new System.Drawing.Point(3, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 93);
            this.panel1.TabIndex = 5;
            // 
            // RGModCheckbox
            // 
            this.RGModCheckbox.AutoSize = true;
            this.RGModCheckbox.Checked = true;
            this.RGModCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RGModCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGModCheckbox.ForeColor = System.Drawing.Color.White;
            this.RGModCheckbox.Location = new System.Drawing.Point(3, 66);
            this.RGModCheckbox.Name = "RGModCheckbox";
            this.RGModCheckbox.Size = new System.Drawing.Size(206, 17);
            this.RGModCheckbox.TabIndex = 5;
            this.RGModCheckbox.Text = "Jamaljé\'s improved cockpit textures";
            this.RGModCheckbox.UseVisualStyleBackColor = true;
            // 
            // audioBirdCheck
            // 
            this.audioBirdCheck.AutoSize = true;
            this.audioBirdCheck.Checked = true;
            this.audioBirdCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.audioBirdCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioBirdCheck.ForeColor = System.Drawing.Color.White;
            this.audioBirdCheck.Location = new System.Drawing.Point(3, 43);
            this.audioBirdCheck.Name = "audioBirdCheck";
            this.audioBirdCheck.Size = new System.Drawing.Size(188, 17);
            this.audioBirdCheck.TabIndex = 4;
            this.audioBirdCheck.Text = "Install AudioBirdXP Sound Mod";
            this.audioBirdCheck.UseVisualStyleBackColor = true;
            this.audioBirdCheck.CheckedChanged += new System.EventHandler(this.audioBirdCheck_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(285, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xplaneDirTextBox
            // 
            this.xplaneDirTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xplaneDirTextBox.Location = new System.Drawing.Point(3, 3);
            this.xplaneDirTextBox.Name = "xplaneDirTextBox";
            this.xplaneDirTextBox.ReadOnly = true;
            this.xplaneDirTextBox.Size = new System.Drawing.Size(270, 20);
            this.xplaneDirTextBox.TabIndex = 0;
            this.xplaneDirTextBox.Text = "C:\\X-Plane\\X-Plane.exe";
            // 
            // InstallLog
            // 
            this.InstallLog.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.InstallLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstallLog.HideSelection = false;
            this.InstallLog.Location = new System.Drawing.Point(3, 3);
            this.InstallLog.Name = "InstallLog";
            this.InstallLog.ReadOnly = true;
            this.InstallLog.Size = new System.Drawing.Size(363, 125);
            this.InstallLog.TabIndex = 1;
            this.InstallLog.Text = "Welcome to ZiboMod Installer! Please select your X-Plane installation path below " +
    "and hit Install to continue!";
            // 
            // InstallButton
            // 
            this.InstallButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallButton.Location = new System.Drawing.Point(288, 279);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(75, 23);
            this.InstallButton.TabIndex = 3;
            this.InstallButton.Text = "Install";
            this.InstallButton.UseVisualStyleBackColor = true;
            this.InstallButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "X-Plane.exe|X-Plane.exe";
            // 
            // InstallOptionsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InstallLog);
            this.Controls.Add(this.InstallButton);
            this.Name = "InstallOptionsPage";
            this.Size = new System.Drawing.Size(368, 319);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox RGModCheckbox;
        private System.Windows.Forms.CheckBox audioBirdCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox xplaneDirTextBox;
        private System.Windows.Forms.RichTextBox InstallLog;
        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
