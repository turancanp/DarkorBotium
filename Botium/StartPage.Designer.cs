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
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.leftpanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NpcSettingBTN = new System.Windows.Forms.Button();
            this.GlobalSettingBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TargetnameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UridiumHourLabel = new System.Windows.Forms.Label();
            this.UriLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreditsHourLabel = new System.Windows.Forms.Label();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TargetShieldBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.TargetHealthBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.PlayerShieldBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.PlayerHealthBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.StartBTN = new System.Windows.Forms.Button();
            this.leftpanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTBox
            // 
            this.LoginTBox.Location = new System.Drawing.Point(4, 39);
            this.LoginTBox.Name = "LoginTBox";
            this.LoginTBox.Size = new System.Drawing.Size(112, 20);
            this.LoginTBox.TabIndex = 2;
            // 
            // PasswordTBox
            // 
            this.PasswordTBox.Location = new System.Drawing.Point(5, 85);
            this.PasswordTBox.Name = "PasswordTBox";
            this.PasswordTBox.Size = new System.Drawing.Size(112, 20);
            this.PasswordTBox.TabIndex = 3;
            this.PasswordTBox.UseSystemPasswordChar = true;
            // 
            // LoginBTN
            // 
            this.LoginBTN.ForeColor = System.Drawing.Color.Black;
            this.LoginBTN.Location = new System.Drawing.Point(5, 111);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(111, 23);
            this.LoginBTN.TabIndex = 4;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // GameBTN
            // 
            this.GameBTN.ForeColor = System.Drawing.Color.Black;
            this.GameBTN.Location = new System.Drawing.Point(4, 19);
            this.GameBTN.Name = "GameBTN";
            this.GameBTN.Size = new System.Drawing.Size(115, 23);
            this.GameBTN.TabIndex = 3;
            this.GameBTN.Text = "Show Game";
            this.GameBTN.UseVisualStyleBackColor = true;
            this.GameBTN.Click += new System.EventHandler(this.GameBTN_Click);
            // 
            // BrowserBTN
            // 
            this.BrowserBTN.ForeColor = System.Drawing.Color.Black;
            this.BrowserBTN.Location = new System.Drawing.Point(4, 48);
            this.BrowserBTN.Name = "BrowserBTN";
            this.BrowserBTN.Size = new System.Drawing.Size(115, 23);
            this.BrowserBTN.TabIndex = 4;
            this.BrowserBTN.Text = "Show Home";
            this.BrowserBTN.UseVisualStyleBackColor = true;
            this.BrowserBTN.Click += new System.EventHandler(this.BrowserBTN_Click);
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(150)))));
            this.LogBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LogBox.Location = new System.Drawing.Point(0, 370);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(124, 92);
            this.LogBox.TabIndex = 6;
            this.LogBox.Text = "";
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(91)))), ((int)(((byte)(114)))));
            this.leftpanel.Controls.Add(this.groupBox3);
            this.leftpanel.Controls.Add(this.groupBox2);
            this.leftpanel.Controls.Add(this.groupBox1);
            this.leftpanel.Controls.Add(this.LogBox);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(124, 462);
            this.leftpanel.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.GameBTN);
            this.groupBox3.Controls.Add(this.BrowserBTN);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(0, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 90);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Browser";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.StartBTN);
            this.groupBox2.Controls.Add(this.NpcSettingBTN);
            this.groupBox2.Controls.Add(this.GlobalSettingBTN);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 118);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // NpcSettingBTN
            // 
            this.NpcSettingBTN.ForeColor = System.Drawing.Color.Black;
            this.NpcSettingBTN.Location = new System.Drawing.Point(5, 19);
            this.NpcSettingBTN.Name = "NpcSettingBTN";
            this.NpcSettingBTN.Size = new System.Drawing.Size(115, 23);
            this.NpcSettingBTN.TabIndex = 7;
            this.NpcSettingBTN.Text = "Npc Settings";
            this.NpcSettingBTN.UseVisualStyleBackColor = true;
            this.NpcSettingBTN.Click += new System.EventHandler(this.NpcSettingBTN_Click);
            // 
            // GlobalSettingBTN
            // 
            this.GlobalSettingBTN.ForeColor = System.Drawing.Color.Black;
            this.GlobalSettingBTN.Location = new System.Drawing.Point(5, 48);
            this.GlobalSettingBTN.Name = "GlobalSettingBTN";
            this.GlobalSettingBTN.Size = new System.Drawing.Size(115, 23);
            this.GlobalSettingBTN.TabIndex = 8;
            this.GlobalSettingBTN.Text = "Bot Settings";
            this.GlobalSettingBTN.UseVisualStyleBackColor = true;
            this.GlobalSettingBTN.Click += new System.EventHandler(this.GlobalSettingBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PasswordTBox);
            this.groupBox1.Controls.Add(this.LoginBTN);
            this.groupBox1.Controls.Add(this.LoginTBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 153);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "PW:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(91)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.TargetnameLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.UridiumHourLabel);
            this.panel1.Controls.Add(this.UriLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CreditsHourLabel);
            this.panel1.Controls.Add(this.MoneyLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TargetShieldBar);
            this.panel1.Controls.Add(this.TargetHealthBar);
            this.panel1.Controls.Add(this.PlayerShieldBar);
            this.panel1.Controls.Add(this.PlayerHealthBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(124, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 92);
            this.panel1.TabIndex = 0;
            // 
            // TargetnameLabel
            // 
            this.TargetnameLabel.AutoSize = true;
            this.TargetnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TargetnameLabel.ForeColor = System.Drawing.Color.White;
            this.TargetnameLabel.Location = new System.Drawing.Point(373, 3);
            this.TargetnameLabel.Name = "TargetnameLabel";
            this.TargetnameLabel.Size = new System.Drawing.Size(29, 29);
            this.TargetnameLabel.TabIndex = 18;
            this.TargetnameLabel.Text = "--";
            this.TargetnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Player";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UridiumHourLabel
            // 
            this.UridiumHourLabel.AutoSize = true;
            this.UridiumHourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UridiumHourLabel.ForeColor = System.Drawing.Color.White;
            this.UridiumHourLabel.Location = new System.Drawing.Point(760, 63);
            this.UridiumHourLabel.Name = "UridiumHourLabel";
            this.UridiumHourLabel.Size = new System.Drawing.Size(18, 20);
            this.UridiumHourLabel.TabIndex = 16;
            this.UridiumHourLabel.Text = "0";
            // 
            // UriLabel
            // 
            this.UriLabel.AutoSize = true;
            this.UriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UriLabel.ForeColor = System.Drawing.Color.White;
            this.UriLabel.Location = new System.Drawing.Point(739, 43);
            this.UriLabel.Name = "UriLabel";
            this.UriLabel.Size = new System.Drawing.Size(18, 20);
            this.UriLabel.TabIndex = 15;
            this.UriLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(666, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Uridium / h :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(666, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Uridium :";
            // 
            // CreditsHourLabel
            // 
            this.CreditsHourLabel.AutoSize = true;
            this.CreditsHourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreditsHourLabel.ForeColor = System.Drawing.Color.White;
            this.CreditsHourLabel.Location = new System.Drawing.Point(760, 23);
            this.CreditsHourLabel.Name = "CreditsHourLabel";
            this.CreditsHourLabel.Size = new System.Drawing.Size(18, 20);
            this.CreditsHourLabel.TabIndex = 12;
            this.CreditsHourLabel.Text = "0";
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MoneyLabel.ForeColor = System.Drawing.Color.White;
            this.MoneyLabel.Location = new System.Drawing.Point(739, 3);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(18, 20);
            this.MoneyLabel.TabIndex = 11;
            this.MoneyLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(666, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Credits / h :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(666, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Credits :";
            // 
            // TargetShieldBar
            // 
            this.TargetShieldBar.BackColor = System.Drawing.Color.Silver;
            this.TargetShieldBar.BorderRadius = 0;
            this.TargetShieldBar.Location = new System.Drawing.Point(378, 55);
            this.TargetShieldBar.MaximumValue = 100;
            this.TargetShieldBar.Name = "TargetShieldBar";
            this.TargetShieldBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(206)))));
            this.TargetShieldBar.Size = new System.Drawing.Size(272, 13);
            this.TargetShieldBar.TabIndex = 12;
            this.TargetShieldBar.Value = 0;
            // 
            // TargetHealthBar
            // 
            this.TargetHealthBar.BackColor = System.Drawing.Color.Silver;
            this.TargetHealthBar.BorderRadius = 0;
            this.TargetHealthBar.Location = new System.Drawing.Point(378, 36);
            this.TargetHealthBar.MaximumValue = 100;
            this.TargetHealthBar.Name = "TargetHealthBar";
            this.TargetHealthBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(167)))), ((int)(((byte)(0)))));
            this.TargetHealthBar.Size = new System.Drawing.Size(272, 13);
            this.TargetHealthBar.TabIndex = 11;
            this.TargetHealthBar.Value = 0;
            // 
            // PlayerShieldBar
            // 
            this.PlayerShieldBar.BackColor = System.Drawing.Color.Silver;
            this.PlayerShieldBar.BorderRadius = 0;
            this.PlayerShieldBar.Location = new System.Drawing.Point(10, 55);
            this.PlayerShieldBar.MaximumValue = 100;
            this.PlayerShieldBar.Name = "PlayerShieldBar";
            this.PlayerShieldBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(206)))));
            this.PlayerShieldBar.Size = new System.Drawing.Size(272, 13);
            this.PlayerShieldBar.TabIndex = 10;
            this.PlayerShieldBar.Value = 0;
            // 
            // PlayerHealthBar
            // 
            this.PlayerHealthBar.BackColor = System.Drawing.Color.Silver;
            this.PlayerHealthBar.BorderRadius = 0;
            this.PlayerHealthBar.Location = new System.Drawing.Point(10, 36);
            this.PlayerHealthBar.MaximumValue = 100;
            this.PlayerHealthBar.Name = "PlayerHealthBar";
            this.PlayerHealthBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(167)))), ((int)(((byte)(0)))));
            this.PlayerHealthBar.Size = new System.Drawing.Size(272, 13);
            this.PlayerHealthBar.TabIndex = 9;
            this.PlayerHealthBar.Value = 0;
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(150)))));
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.ForeColor = System.Drawing.Color.White;
            this.centerPanel.Location = new System.Drawing.Point(124, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(884, 370);
            this.centerPanel.TabIndex = 7;
            // 
            // StartBTN
            // 
            this.StartBTN.ForeColor = System.Drawing.Color.Black;
            this.StartBTN.Location = new System.Drawing.Point(5, 76);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(115, 23);
            this.StartBTN.TabIndex = 9;
            this.StartBTN.Text = "Start Bot";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1008, 462);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftpanel);
            this.MinimumSize = new System.Drawing.Size(1024, 500);
            this.Name = "StartPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Botium";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuProgressBar TargetShieldBar;
        private Bunifu.Framework.UI.BunifuProgressBar TargetHealthBar;
        private Bunifu.Framework.UI.BunifuProgressBar PlayerShieldBar;
        private Bunifu.Framework.UI.BunifuProgressBar PlayerHealthBar;
        private System.Windows.Forms.TextBox LoginTBox;
        private System.Windows.Forms.TextBox PasswordTBox;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Button GameBTN;
        private System.Windows.Forms.Button BrowserBTN;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GlobalSettingBTN;
        private System.Windows.Forms.Button NpcSettingBTN;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Label TargetnameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UridiumHourLabel;
        private System.Windows.Forms.Label UriLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CreditsHourLabel;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button StartBTN;
    }
}