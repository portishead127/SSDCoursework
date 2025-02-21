namespace SSDCoursework.Forms.Misc
{
    partial class SettingsForm
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
            this.lblDarkMode = new System.Windows.Forms.Label();
            this.rdoDarkMode = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeUsername = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectPFP = new System.Windows.Forms.Button();
            this.btnRemovePFP = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.rdoLeaderboard = new System.Windows.Forms.RadioButton();
            this.lblScoreOnLeaderboard = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDarkMode
            // 
            this.lblDarkMode.BackColor = System.Drawing.Color.Silver;
            this.lblDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDarkMode.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblDarkMode.ForeColor = System.Drawing.Color.Black;
            this.lblDarkMode.Location = new System.Drawing.Point(332, 359);
            this.lblDarkMode.Name = "lblDarkMode";
            this.lblDarkMode.Size = new System.Drawing.Size(384, 55);
            this.lblDarkMode.TabIndex = 0;
            this.lblDarkMode.Tag = "ButtonAccent";
            this.lblDarkMode.Text = "Use dark mode";
            this.lblDarkMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoDarkMode
            // 
            this.rdoDarkMode.AutoCheck = false;
            this.rdoDarkMode.AutoSize = true;
            this.rdoDarkMode.Location = new System.Drawing.Point(1104, 359);
            this.rdoDarkMode.Name = "rdoDarkMode";
            this.rdoDarkMode.Padding = new System.Windows.Forms.Padding(70, 11, 30, 30);
            this.rdoDarkMode.Size = new System.Drawing.Size(114, 54);
            this.rdoDarkMode.TabIndex = 13;
            this.rdoDarkMode.Tag = "MainColour";
            this.rdoDarkMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoDarkMode.UseVisualStyleBackColor = true;
            this.rdoDarkMode.Click += new System.EventHandler(this.rdoDarkMode_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(640, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(554, 31);
            this.textBox1.TabIndex = 14;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.AutoSize = true;
            this.btnChangePassword.BackColor = System.Drawing.Color.Silver;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnChangePassword.Location = new System.Drawing.Point(338, 122);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(260, 55);
            this.btnChangePassword.TabIndex = 16;
            this.btnChangePassword.Tag = "ButtonAccent";
            this.btnChangePassword.Text = "Change password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnChangeUsername
            // 
            this.btnChangeUsername.BackColor = System.Drawing.Color.Silver;
            this.btnChangeUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUsername.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnChangeUsername.Location = new System.Drawing.Point(338, 12);
            this.btnChangeUsername.Name = "btnChangeUsername";
            this.btnChangeUsername.Size = new System.Drawing.Size(260, 55);
            this.btnChangeUsername.TabIndex = 17;
            this.btnChangeUsername.Tag = "ButtonAccent";
            this.btnChangeUsername.Text = "Change username";
            this.btnChangeUsername.UseVisualStyleBackColor = false;
            this.btnChangeUsername.Click += new System.EventHandler(this.btnUsername_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textBox2.Location = new System.Drawing.Point(640, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(544, 31);
            this.textBox2.TabIndex = 18;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            // 
            // btnSelectPFP
            // 
            this.btnSelectPFP.AutoSize = true;
            this.btnSelectPFP.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnSelectPFP.Location = new System.Drawing.Point(12, 313);
            this.btnSelectPFP.Name = "btnSelectPFP";
            this.btnSelectPFP.Size = new System.Drawing.Size(297, 44);
            this.btnSelectPFP.TabIndex = 19;
            this.btnSelectPFP.Tag = "ButtonAccent";
            this.btnSelectPFP.Text = "Select profile picture";
            this.btnSelectPFP.UseVisualStyleBackColor = true;
            this.btnSelectPFP.Click += new System.EventHandler(this.btnSelectPFP_Click);
            // 
            // btnRemovePFP
            // 
            this.btnRemovePFP.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold);
            this.btnRemovePFP.Location = new System.Drawing.Point(12, 359);
            this.btnRemovePFP.Name = "btnRemovePFP";
            this.btnRemovePFP.Size = new System.Drawing.Size(297, 29);
            this.btnRemovePFP.TabIndex = 21;
            this.btnRemovePFP.Tag = "ButtonAccent";
            this.btnRemovePFP.Text = "Remove profile picture";
            this.btnRemovePFP.UseVisualStyleBackColor = true;
            this.btnRemovePFP.Click += new System.EventHandler(this.btnRemovePFP_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.AutoSize = true;
            this.btnDeleteAccount.BackColor = System.Drawing.Color.Silver;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteAccount.Location = new System.Drawing.Point(454, 456);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(322, 49);
            this.btnDeleteAccount.TabIndex = 22;
            this.btnDeleteAccount.Tag = "ButtonAccent";
            this.btnDeleteAccount.Text = "DELETE ACCOUNT";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // rdoLeaderboard
            // 
            this.rdoLeaderboard.AutoCheck = false;
            this.rdoLeaderboard.AutoSize = true;
            this.rdoLeaderboard.Location = new System.Drawing.Point(1104, 281);
            this.rdoLeaderboard.Name = "rdoLeaderboard";
            this.rdoLeaderboard.Padding = new System.Windows.Forms.Padding(70, 11, 30, 30);
            this.rdoLeaderboard.Size = new System.Drawing.Size(114, 54);
            this.rdoLeaderboard.TabIndex = 24;
            this.rdoLeaderboard.Tag = "MainColour";
            this.rdoLeaderboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoLeaderboard.UseVisualStyleBackColor = true;
            this.rdoLeaderboard.Click += new System.EventHandler(this.rdoLeaderboard_Click);
            // 
            // lblScoreOnLeaderboard
            // 
            this.lblScoreOnLeaderboard.BackColor = System.Drawing.Color.Silver;
            this.lblScoreOnLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblScoreOnLeaderboard.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblScoreOnLeaderboard.ForeColor = System.Drawing.Color.Black;
            this.lblScoreOnLeaderboard.Location = new System.Drawing.Point(332, 281);
            this.lblScoreOnLeaderboard.Name = "lblScoreOnLeaderboard";
            this.lblScoreOnLeaderboard.Size = new System.Drawing.Size(384, 55);
            this.lblScoreOnLeaderboard.TabIndex = 23;
            this.lblScoreOnLeaderboard.Tag = "ButtonAccent";
            this.lblScoreOnLeaderboard.Text = "Show scores on leaderboard";
            this.lblScoreOnLeaderboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1230, 633);
            this.Controls.Add(this.rdoLeaderboard);
            this.Controls.Add(this.lblScoreOnLeaderboard);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnRemovePFP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelectPFP);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnChangeUsername);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rdoDarkMode);
            this.Controls.Add(this.lblDarkMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Tag = "MainColour";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDarkMode;
        private System.Windows.Forms.RadioButton rdoDarkMode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeUsername;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectPFP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRemovePFP;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.RadioButton rdoLeaderboard;
        private System.Windows.Forms.Label lblScoreOnLeaderboard;
    }
}