namespace ZibomodInstaller
{
    partial class InstallPage
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
            try
            {
                InstallActionWorker.Abort();
            } catch (System.NullReferenceException)
            {

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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.closeButton = new System.Windows.Forms.Button();
            this.CurrentAction = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EULApanel = new System.Windows.Forms.Panel();
            this.acceptEULAbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.EULApanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(36, 160);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(357, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.closeButton.Enabled = false;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(81)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(318, 270);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // CurrentAction
            // 
            this.CurrentAction.AutoSize = true;
            this.CurrentAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.CurrentAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentAction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentAction.ForeColor = System.Drawing.Color.White;
            this.CurrentAction.Location = new System.Drawing.Point(33, 129);
            this.CurrentAction.Name = "CurrentAction";
            this.CurrentAction.Size = new System.Drawing.Size(55, 17);
            this.CurrentAction.TabIndex = 9;
            this.CurrentAction.Text = "Nothing";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 108);
            this.panel1.TabIndex = 10;
            // 
            // EULApanel
            // 
            this.EULApanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.EULApanel.Controls.Add(this.acceptEULAbtn);
            this.EULApanel.Controls.Add(this.label1);
            this.EULApanel.Controls.Add(this.richTextBox1);
            this.EULApanel.Location = new System.Drawing.Point(0, 61);
            this.EULApanel.Name = "EULApanel";
            this.EULApanel.Size = new System.Drawing.Size(429, 185);
            this.EULApanel.TabIndex = 11;
            // 
            // acceptEULAbtn
            // 
            this.acceptEULAbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.acceptEULAbtn.Enabled = false;
            this.acceptEULAbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(81)))));
            this.acceptEULAbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptEULAbtn.ForeColor = System.Drawing.Color.White;
            this.acceptEULAbtn.Location = new System.Drawing.Point(318, 149);
            this.acceptEULAbtn.Name = "acceptEULAbtn";
            this.acceptEULAbtn.Size = new System.Drawing.Size(75, 23);
            this.acceptEULAbtn.TabIndex = 2;
            this.acceptEULAbtn.Text = "Accept";
            this.acceptEULAbtn.UseVisualStyleBackColor = false;
            this.acceptEULAbtn.Click += new System.EventHandler(this.acceptEULAbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please read the EULA below to unlock the accept button";
            this.label1.Click += new System.EventHandler(this.EULAlabel_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(21, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(385, 77);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "No EULA loaded.\nPress the text above to unlock install button.";
            // 
            // InstallPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EULApanel);
            this.Controls.Add(this.CurrentAction);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Name = "InstallPage";
            this.Size = new System.Drawing.Size(429, 322);
            this.EULApanel.ResumeLayout(false);
            this.EULApanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Label CurrentAction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel EULApanel;
        private System.Windows.Forms.Button acceptEULAbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
