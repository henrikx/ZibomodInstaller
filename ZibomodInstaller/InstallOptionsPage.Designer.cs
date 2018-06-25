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
            this.textuelabel = new System.Windows.Forms.Label();
            this.dropdownbox = new System.Windows.Forms.ComboBox();
            this.forceInstallCheckbox = new System.Windows.Forms.CheckBox();
            this.InstallButton = new System.Windows.Forms.Button();
            this.audioBirdCheck = new System.Windows.Forms.CheckBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.xplaneDirTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.textuelabel);
            this.panel1.Controls.Add(this.dropdownbox);
            this.panel1.Controls.Add(this.forceInstallCheckbox);
            this.panel1.Controls.Add(this.InstallButton);
            this.panel1.Controls.Add(this.audioBirdCheck);
            this.panel1.Controls.Add(this.BrowseButton);
            this.panel1.Controls.Add(this.xplaneDirTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 168);
            this.panel1.TabIndex = 5;
            // 
            // textuelabel
            // 
            this.textuelabel.AutoSize = true;
            this.textuelabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.textuelabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textuelabel.ForeColor = System.Drawing.Color.White;
            this.textuelabel.Location = new System.Drawing.Point(79, 100);
            this.textuelabel.Name = "textuelabel";
            this.textuelabel.Size = new System.Drawing.Size(99, 13);
            this.textuelabel.TabIndex = 8;
            this.textuelabel.Text = "Texture resolution";
            // 
            // dropdownbox
            // 
            this.dropdownbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.dropdownbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownbox.ForeColor = System.Drawing.Color.White;
            this.dropdownbox.FormattingEnabled = true;
            this.dropdownbox.Items.AddRange(new object[] {
            "4k",
            "2k"});
            this.dropdownbox.Location = new System.Drawing.Point(37, 97);
            this.dropdownbox.Name = "dropdownbox";
            this.dropdownbox.Size = new System.Drawing.Size(36, 21);
            this.dropdownbox.TabIndex = 7;
            // 
            // forceInstallCheckbox
            // 
            this.forceInstallCheckbox.AutoSize = true;
            this.forceInstallCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.forceInstallCheckbox.ForeColor = System.Drawing.Color.White;
            this.forceInstallCheckbox.Location = new System.Drawing.Point(37, 125);
            this.forceInstallCheckbox.Name = "forceInstallCheckbox";
            this.forceInstallCheckbox.Size = new System.Drawing.Size(132, 17);
            this.forceInstallCheckbox.TabIndex = 6;
            this.forceInstallCheckbox.Text = "Ignore update check";
            this.forceInstallCheckbox.UseVisualStyleBackColor = true;
            // 
            // InstallButton
            // 
            this.InstallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.InstallButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(81)))));
            this.InstallButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.InstallButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.InstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.InstallButton.ForeColor = System.Drawing.Color.White;
            this.InstallButton.Location = new System.Drawing.Point(319, 120);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(75, 22);
            this.InstallButton.TabIndex = 0;
            this.InstallButton.Text = "Install";
            this.InstallButton.UseVisualStyleBackColor = false;
            this.InstallButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // audioBirdCheck
            // 
            this.audioBirdCheck.AutoSize = true;
            this.audioBirdCheck.Checked = true;
            this.audioBirdCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.audioBirdCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.audioBirdCheck.ForeColor = System.Drawing.Color.White;
            this.audioBirdCheck.Location = new System.Drawing.Point(37, 75);
            this.audioBirdCheck.Name = "audioBirdCheck";
            this.audioBirdCheck.Size = new System.Drawing.Size(192, 19);
            this.audioBirdCheck.TabIndex = 4;
            this.audioBirdCheck.Text = "Install AudioBirdXP Sound Mod";
            this.audioBirdCheck.UseVisualStyleBackColor = true;
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.BrowseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.BrowseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(81)))));
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton.ForeColor = System.Drawing.Color.White;
            this.BrowseButton.Location = new System.Drawing.Point(319, 35);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 22);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // xplaneDirTextBox
            // 
            this.xplaneDirTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.xplaneDirTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xplaneDirTextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xplaneDirTextBox.Location = new System.Drawing.Point(37, 35);
            this.xplaneDirTextBox.Name = "xplaneDirTextBox";
            this.xplaneDirTextBox.ReadOnly = true;
            this.xplaneDirTextBox.Size = new System.Drawing.Size(276, 22);
            this.xplaneDirTextBox.TabIndex = 3;
            this.xplaneDirTextBox.Text = "C:\\X-Plane\\X-Plane.exe";
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
            this.Name = "InstallOptionsPage";
            this.Size = new System.Drawing.Size(429, 322);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.CheckBox audioBirdCheck;
        public System.Windows.Forms.TextBox xplaneDirTextBox;
        public System.Windows.Forms.CheckBox forceInstallCheckbox;
        private System.Windows.Forms.Label textuelabel;
        public System.Windows.Forms.ComboBox dropdownbox;
    }
}
