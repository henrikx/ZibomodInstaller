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
            this.closebutton = new System.Windows.Forms.Button();
            this.titleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.displayEULA1 = new ZibomodInstaller.DisplayEULA();
            this.installOptionsPage1 = new ZibomodInstaller.InstallOptionsPage();
            this.installPage1 = new ZibomodInstaller.InstallPage();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.closebutton.FlatAppearance.BorderSize = 0;
            this.closebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.Font = new System.Drawing.Font("Calibri", 8.5F);
            this.closebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.closebutton.Location = new System.Drawing.Point(387, 3);
            this.closebutton.Name = "closebutton";
            this.closebutton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.closebutton.Size = new System.Drawing.Size(42, 22);
            this.closebutton.TabIndex = 1;
            this.closebutton.Text = "X";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.xCloseButton);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.titleBar.Controls.Add(this.label1);
            this.titleBar.Controls.Add(this.closebutton);
            this.titleBar.Location = new System.Drawing.Point(0, -3);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(430, 56);
            this.titleBar.TabIndex = 2;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.titleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "ZiboMod Installer";
            // 
            // displayEULA1
            // 
            this.displayEULA1.Location = new System.Drawing.Point(0, 54);
            this.displayEULA1.Name = "displayEULA1";
            this.displayEULA1.Size = new System.Drawing.Size(429, 322);
            this.displayEULA1.TabIndex = 5;
            // 
            // installOptionsPage1
            // 
            this.installOptionsPage1.Location = new System.Drawing.Point(0, 58);
            this.installOptionsPage1.Name = "installOptionsPage1";
            this.installOptionsPage1.Size = new System.Drawing.Size(429, 322);
            this.installOptionsPage1.TabIndex = 4;
            // 
            // installPage1
            // 
            this.installPage1.Location = new System.Drawing.Point(0, 59);
            this.installPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.installPage1.Name = "installPage1";
            this.installPage1.Size = new System.Drawing.Size(429, 322);
            this.installPage1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(429, 382);
            this.Controls.Add(this.displayEULA1);
            this.Controls.Add(this.installOptionsPage1);
            this.Controls.Add(this.installPage1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "ZiboMod Install/Update Tool";
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Label label1;
        public InstallPage installPage1;
        public System.Windows.Forms.Button closebutton;
        private InstallOptionsPage installOptionsPage1;
        public DisplayEULA displayEULA1;
    }
}

