namespace SSDCoursework.UserControls
{
    partial class SidebarControl
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
            this.components = new System.ComponentModel.Container();
            this.flpSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pbxHamburger = new System.Windows.Forms.PictureBox();
            this.pbxSettingsIcon = new System.Windows.Forms.PictureBox();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlFormHolder = new System.Windows.Forms.Panel();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.lblPageIndicator = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHamburger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSettingsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSidebar
            // 
            this.flpSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.flpSidebar.Controls.Add(this.pbxHamburger);
            this.flpSidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSidebar.Location = new System.Drawing.Point(0, 0);
            this.flpSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.flpSidebar.MinimumSize = new System.Drawing.Size(68, 453);
            this.flpSidebar.Name = "flpSidebar";
            this.flpSidebar.Size = new System.Drawing.Size(120, 768);
            this.flpSidebar.TabIndex = 1;
            // 
            // pbxHamburger
            // 
            this.pbxHamburger.BackColor = System.Drawing.Color.Transparent;
            this.pbxHamburger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHamburger.Image = global::SSDCoursework.Properties.Resources.Hamburger;
            this.pbxHamburger.Location = new System.Drawing.Point(0, 0);
            this.pbxHamburger.Margin = new System.Windows.Forms.Padding(0);
            this.pbxHamburger.Name = "pbxHamburger";
            this.pbxHamburger.Size = new System.Drawing.Size(120, 104);
            this.pbxHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHamburger.TabIndex = 1;
            this.pbxHamburger.TabStop = false;
            this.pbxHamburger.Click += new System.EventHandler(this.pbxHamburger_Click);
            // 
            // pbxSettingsIcon
            // 
            this.pbxSettingsIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxSettingsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxSettingsIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSettingsIcon.Image = global::SSDCoursework.Properties.Resources.EmptyProfilePic;
            this.pbxSettingsIcon.Location = new System.Drawing.Point(0, 660);
            this.pbxSettingsIcon.Name = "pbxSettingsIcon";
            this.pbxSettingsIcon.Size = new System.Drawing.Size(117, 101);
            this.pbxSettingsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSettingsIcon.TabIndex = 0;
            this.pbxSettingsIcon.TabStop = false;
            this.pbxSettingsIcon.Click += new System.EventHandler(this.pbxSettingsIcon_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 5;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // pnlFormHolder
            // 
            this.pnlFormHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFormHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.pnlFormHolder.Location = new System.Drawing.Point(120, 100);
            this.pnlFormHolder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFormHolder.Name = "pnlFormHolder";
            this.pnlFormHolder.Size = new System.Drawing.Size(1266, 668);
            this.pnlFormHolder.TabIndex = 2;
            this.pnlFormHolder.Tag = "";
            // 
            // pbxExit
            // 
            this.pbxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxExit.Image = global::SSDCoursework.Properties.Resources.close_1_;
            this.pbxExit.Location = new System.Drawing.Point(1296, 12);
            this.pbxExit.Name = "pbxExit";
            this.pbxExit.Size = new System.Drawing.Size(87, 75);
            this.pbxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxExit.TabIndex = 1;
            this.pbxExit.TabStop = false;
            this.pbxExit.Click += new System.EventHandler(this.pbxExit_Click);
            // 
            // lblPageIndicator
            // 
            this.lblPageIndicator.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPageIndicator.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageIndicator.ForeColor = System.Drawing.Color.White;
            this.lblPageIndicator.Location = new System.Drawing.Point(0, 0);
            this.lblPageIndicator.Name = "lblPageIndicator";
            this.lblPageIndicator.Size = new System.Drawing.Size(683, 100);
            this.lblPageIndicator.TabIndex = 0;
            this.lblPageIndicator.Text = "Current Page";
            this.lblPageIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblPageIndicator);
            this.panel1.Location = new System.Drawing.Point(120, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 100);
            this.panel1.TabIndex = 3;
            // 
            // SidebarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.pbxSettingsIcon);
            this.Controls.Add(this.pbxExit);
            this.Controls.Add(this.flpSidebar);
            this.Controls.Add(this.pnlFormHolder);
            this.Controls.Add(this.panel1);
            this.Name = "SidebarControl";
            this.Size = new System.Drawing.Size(1386, 768);
            this.Load += new System.EventHandler(this.SidebarControl_Load);
            this.flpSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHamburger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSettingsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxHamburger;
        internal System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.FlowLayoutPanel flpSidebar;
        private System.Windows.Forms.Panel pnlFormHolder;
        private System.Windows.Forms.PictureBox pbxSettingsIcon;
        private System.Windows.Forms.Label lblPageIndicator;
        private System.Windows.Forms.PictureBox pbxExit;
        private System.Windows.Forms.Panel panel1;
    }
}
