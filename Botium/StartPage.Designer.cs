namespace Botium
{
    partial class StartPage
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
            this.LoginTBox = new System.Windows.Forms.TextBox();
            this.PasswordTBox = new System.Windows.Forms.TextBox();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.GameBTN = new System.Windows.Forms.Button();
            this.BrowserBTN = new System.Windows.Forms.Button();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.leftpanel = new System.Windows.Forms.Panel();
            this.toppanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowLogs = new System.Windows.Forms.CheckBox();
            this.NpcSettingBTN = new System.Windows.Forms.Button();
            this.GlobalSettingBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CollectCBox = new System.Windows.Forms.CheckBox();
            this.leftpanel.SuspendLayout();
            this.toppanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTBox
            // 
            this.LoginTBox.Location = new System.Drawing.Point(12, 135);
            this.LoginTBox.Name = "LoginTBox";
            this.LoginTBox.Size = new System.Drawing.Size(100, 20);
            this.LoginTBox.TabIndex = 0;
            // 
            // PasswordTBox
            // 
            this.PasswordTBox.Location = new System.Drawing.Point(12, 161);
            this.PasswordTBox.Name = "PasswordTBox";
            this.PasswordTBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTBox.TabIndex = 1;
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(37, 187);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(75, 23);
            this.LoginBTN.TabIndex = 2;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // GameBTN
            // 
            this.GameBTN.Location = new System.Drawing.Point(37, 77);
            this.GameBTN.Name = "GameBTN";
            this.GameBTN.Size = new System.Drawing.Size(75, 23);
            this.GameBTN.TabIndex = 3;
            this.GameBTN.Text = "Game";
            this.GameBTN.UseVisualStyleBackColor = true;
            this.GameBTN.Click += new System.EventHandler(this.GameBTN_Click);
            // 
            // BrowserBTN
            // 
            this.BrowserBTN.Location = new System.Drawing.Point(37, 106);
            this.BrowserBTN.Name = "BrowserBTN";
            this.BrowserBTN.Size = new System.Drawing.Size(75, 23);
            this.BrowserBTN.TabIndex = 4;
            this.BrowserBTN.Text = "Browser";
            this.BrowserBTN.UseVisualStyleBackColor = true;
            this.BrowserBTN.Click += new System.EventHandler(this.BrowserBTN_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(800, 450);
            this.centerPanel.TabIndex = 5;
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LogBox.Location = new System.Drawing.Point(0, 358);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(124, 92);
            this.LogBox.TabIndex = 6;
            this.LogBox.Text = "";
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.leftpanel.Controls.Add(this.groupBox1);
            this.leftpanel.Controls.Add(this.LogBox);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(124, 450);
            this.leftpanel.TabIndex = 6;
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.toppanel.Controls.Add(this.ShowLogs);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(124, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(676, 38);
            this.toppanel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(124, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 92);
            this.panel1.TabIndex = 0;
            // 
            // ShowLogs
            // 
            this.ShowLogs.AutoSize = true;
            this.ShowLogs.Location = new System.Drawing.Point(6, 12);
            this.ShowLogs.Name = "ShowLogs";
            this.ShowLogs.Size = new System.Drawing.Size(79, 17);
            this.ShowLogs.TabIndex = 0;
            this.ShowLogs.Text = "Show Logs";
            this.ShowLogs.UseVisualStyleBackColor = true;
            // 
            // NpcSettingBTN
            // 
            this.NpcSettingBTN.Location = new System.Drawing.Point(37, 48);
            this.NpcSettingBTN.Name = "NpcSettingBTN";
            this.NpcSettingBTN.Size = new System.Drawing.Size(75, 23);
            this.NpcSettingBTN.TabIndex = 7;
            this.NpcSettingBTN.Text = "Npc";
            this.NpcSettingBTN.UseVisualStyleBackColor = true;
            this.NpcSettingBTN.Click += new System.EventHandler(this.NpcSettingBTN_Click);
            // 
            // GlobalSettingBTN
            // 
            this.GlobalSettingBTN.Location = new System.Drawing.Point(37, 19);
            this.GlobalSettingBTN.Name = "GlobalSettingBTN";
            this.GlobalSettingBTN.Size = new System.Drawing.Size(75, 23);
            this.GlobalSettingBTN.TabIndex = 8;
            this.GlobalSettingBTN.Text = "Settings";
            this.GlobalSettingBTN.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CollectCBox);
            this.groupBox1.Controls.Add(this.GlobalSettingBTN);
            this.groupBox1.Controls.Add(this.NpcSettingBTN);
            this.groupBox1.Controls.Add(this.LoginTBox);
            this.groupBox1.Controls.Add(this.LoginBTN);
            this.groupBox1.Controls.Add(this.GameBTN);
            this.groupBox1.Controls.Add(this.PasswordTBox);
            this.groupBox1.Controls.Add(this.BrowserBTN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 358);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botium";
            // 
            // CollectCBox
            // 
            this.CollectCBox.AutoSize = true;
            this.CollectCBox.Location = new System.Drawing.Point(12, 216);
            this.CollectCBox.Name = "CollectCBox";
            this.CollectCBox.Size = new System.Drawing.Size(83, 17);
            this.CollectCBox.TabIndex = 9;
            this.CollectCBox.Text = "CollectCBox";
            this.CollectCBox.UseVisualStyleBackColor = true;
            this.CollectCBox.CheckedChanged += new System.EventHandler(this.CollectCBox_CheckedChanged);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.leftpanel);
            this.Controls.Add(this.centerPanel);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.leftpanel.ResumeLayout(false);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTBox;
        private System.Windows.Forms.TextBox PasswordTBox;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Button GameBTN;
        private System.Windows.Forms.Button BrowserBTN;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GlobalSettingBTN;
        private System.Windows.Forms.Button NpcSettingBTN;
        private System.Windows.Forms.CheckBox ShowLogs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CollectCBox;
    }
}