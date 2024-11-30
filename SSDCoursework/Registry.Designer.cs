namespace SSDCoursework
{
    partial class Registry
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
            this.components = new System.ComponentModel.Container();
            this.pnlHamburgerHolder = new System.Windows.Forms.Panel();
            this.lblHamburgerText = new System.Windows.Forms.Label();
            this.pbxHamburger = new System.Windows.Forms.PictureBox();
            this.flpSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlChildFormHolder = new System.Windows.Forms.Panel();
            this.pnlHamburgerHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHamburger)).BeginInit();
            this.flpSidebar.SuspendLayout();
            this.pnlSignUp.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHamburgerHolder
            // 
            this.pnlHamburgerHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlHamburgerHolder.Controls.Add(this.lblHamburgerText);
            this.pnlHamburgerHolder.Controls.Add(this.pbxHamburger);
            this.pnlHamburgerHolder.Location = new System.Drawing.Point(0, 0);
            this.pnlHamburgerHolder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHamburgerHolder.Name = "pnlHamburgerHolder";
            this.pnlHamburgerHolder.Size = new System.Drawing.Size(223, 83);
            this.pnlHamburgerHolder.TabIndex = 0;
            // 
            // lblHamburgerText
            // 
            this.lblHamburgerText.AutoSize = true;
            this.lblHamburgerText.ForeColor = System.Drawing.Color.White;
            this.lblHamburgerText.Location = new System.Drawing.Point(102, 37);
            this.lblHamburgerText.Name = "lblHamburgerText";
            this.lblHamburgerText.Size = new System.Drawing.Size(45, 13);
            this.lblHamburgerText.TabIndex = 2;
            this.lblHamburgerText.Text = "Registry";
            // 
            // pbxHamburger
            // 
            this.pbxHamburger.BackColor = System.Drawing.Color.White;
            this.pbxHamburger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHamburger.Location = new System.Drawing.Point(11, 12);
            this.pbxHamburger.Name = "pbxHamburger";
            this.pbxHamburger.Size = new System.Drawing.Size(35, 56);
            this.pbxHamburger.TabIndex = 1;
            this.pbxHamburger.TabStop = false;
            this.pbxHamburger.Click += new System.EventHandler(this.pbxHamburger_Click);
            // 
            // flpSidebar
            // 
            this.flpSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.flpSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpSidebar.Controls.Add(this.pnlHamburgerHolder);
            this.flpSidebar.Controls.Add(this.pnlSignUp);
            this.flpSidebar.Controls.Add(this.pnlLogin);
            this.flpSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpSidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSidebar.Location = new System.Drawing.Point(0, 0);
            this.flpSidebar.Name = "flpSidebar";
            this.flpSidebar.Size = new System.Drawing.Size(55, 453);
            this.flpSidebar.TabIndex = 0;
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.BackColor = System.Drawing.Color.Transparent;
            this.pnlSignUp.Controls.Add(this.btnSignUp);
            this.pnlSignUp.Location = new System.Drawing.Point(0, 83);
            this.pnlSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(258, 47);
            this.pnlSignUp.TabIndex = 3;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Image = global::SSDCoursework.Properties.Resources.Login_symbol2_1_;
            this.btnSignUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUp.Location = new System.Drawing.Point(-17, -12);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.btnSignUp.Size = new System.Drawing.Size(287, 67);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "               Sign up";
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Location = new System.Drawing.Point(0, 130);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(258, 47);
            this.pnlLogin.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = global::SSDCoursework.Properties.Resources.Login_symbol2_1_;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(-17, -12);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(20, 4, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(291, 67);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "               Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // pnlChildFormHolder
            // 
            this.pnlChildFormHolder.Location = new System.Drawing.Point(55, 0);
            this.pnlChildFormHolder.Name = "pnlChildFormHolder";
            this.pnlChildFormHolder.Size = new System.Drawing.Size(815, 453);
            this.pnlChildFormHolder.TabIndex = 1;
            this.pnlChildFormHolder.Tag = "";
            // 
            // Registry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(870, 453);
            this.Controls.Add(this.flpSidebar);
            this.Controls.Add(this.pnlChildFormHolder);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Registry";
            this.Text = "Registry";
            this.Resize += new System.EventHandler(this.Registry_Resize);
            this.pnlHamburgerHolder.ResumeLayout(false);
            this.pnlHamburgerHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHamburger)).EndInit();
            this.flpSidebar.ResumeLayout(false);
            this.pnlSignUp.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHamburgerHolder;
        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.Label lblHamburgerText;
        private System.Windows.Forms.PictureBox pbxHamburger;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlChildFormHolder;
        public System.Windows.Forms.FlowLayoutPanel flpSidebar;
    }
}

