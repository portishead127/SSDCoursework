namespace SSDCoursework
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
            this.pnlHamburgerHolder = new System.Windows.Forms.Panel();
            this.pbxHamburger = new System.Windows.Forms.PictureBox();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.flpBannerbar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPageIndicatorHolder = new System.Windows.Forms.Panel();
            this.lblPageIndicator = new System.Windows.Forms.Label();
            this.pnlChildFormHolder = new System.Windows.Forms.Panel();
            this.flpSidebar.SuspendLayout();
            this.pnlHamburgerHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHamburger)).BeginInit();
            this.flpBannerbar.SuspendLayout();
            this.pnlPageIndicatorHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSidebar
            // 
            this.flpSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.flpSidebar.Controls.Add(this.pnlHamburgerHolder);
            this.flpSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpSidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSidebar.Location = new System.Drawing.Point(0, 0);
            this.flpSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.flpSidebar.MinimumSize = new System.Drawing.Size(68, 453);
            this.flpSidebar.Name = "flpSidebar";
            this.flpSidebar.Size = new System.Drawing.Size(120, 599);
            this.flpSidebar.TabIndex = 1;
            // 
            // pnlHamburgerHolder
            // 
            this.pnlHamburgerHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlHamburgerHolder.Controls.Add(this.pbxHamburger);
            this.pnlHamburgerHolder.Location = new System.Drawing.Point(0, 0);
            this.pnlHamburgerHolder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHamburgerHolder.Name = "pnlHamburgerHolder";
            this.pnlHamburgerHolder.Size = new System.Drawing.Size(120, 96);
            this.pnlHamburgerHolder.TabIndex = 0;
            // 
            // pbxHamburger
            // 
            this.pbxHamburger.BackColor = System.Drawing.Color.Transparent;
            this.pbxHamburger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHamburger.Image = global::SSDCoursework.Properties.Resources.Hamburger;
            this.pbxHamburger.Location = new System.Drawing.Point(0, 3);
            this.pbxHamburger.Margin = new System.Windows.Forms.Padding(0);
            this.pbxHamburger.Name = "pbxHamburger";
            this.pbxHamburger.Size = new System.Drawing.Size(109, 80);
            this.pbxHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHamburger.TabIndex = 1;
            this.pbxHamburger.TabStop = false;
            this.pbxHamburger.Click += new System.EventHandler(this.pbxHamburger_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 5;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // flpBannerbar
            // 
            this.flpBannerbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.flpBannerbar.Controls.Add(this.pnlPageIndicatorHolder);
            this.flpBannerbar.Location = new System.Drawing.Point(68, 0);
            this.flpBannerbar.Margin = new System.Windows.Forms.Padding(0);
            this.flpBannerbar.Name = "flpBannerbar";
            this.flpBannerbar.Size = new System.Drawing.Size(1980, 96);
            this.flpBannerbar.TabIndex = 2;
            // 
            // pnlPageIndicatorHolder
            // 
            this.pnlPageIndicatorHolder.Controls.Add(this.lblPageIndicator);
            this.pnlPageIndicatorHolder.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPageIndicatorHolder.Location = new System.Drawing.Point(3, 3);
            this.pnlPageIndicatorHolder.Name = "pnlPageIndicatorHolder";
            this.pnlPageIndicatorHolder.Size = new System.Drawing.Size(838, 100);
            this.pnlPageIndicatorHolder.TabIndex = 1;
            // 
            // lblPageIndicator
            // 
            this.lblPageIndicator.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageIndicator.ForeColor = System.Drawing.Color.White;
            this.lblPageIndicator.Location = new System.Drawing.Point(53, 0);
            this.lblPageIndicator.Name = "lblPageIndicator";
            this.lblPageIndicator.Size = new System.Drawing.Size(626, 90);
            this.lblPageIndicator.TabIndex = 0;
            this.lblPageIndicator.Text = "Current Page";
            // 
            // pnlChildFormHolder
            // 
            this.pnlChildFormHolder.AutoSize = true;
            this.pnlChildFormHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.pnlChildFormHolder.Location = new System.Drawing.Point(120, 96);
            this.pnlChildFormHolder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlChildFormHolder.Name = "pnlChildFormHolder";
            this.pnlChildFormHolder.Size = new System.Drawing.Size(1111, 985);
            this.pnlChildFormHolder.TabIndex = 2;
            this.pnlChildFormHolder.Tag = "";
            // 
            // SidebarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.flpSidebar);
            this.Controls.Add(this.flpBannerbar);
            this.Controls.Add(this.pnlChildFormHolder);
            this.Name = "SidebarControl";
            this.Size = new System.Drawing.Size(912, 599);
            this.flpSidebar.ResumeLayout(false);
            this.pnlHamburgerHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHamburger)).EndInit();
            this.flpBannerbar.ResumeLayout(false);
            this.pnlPageIndicatorHolder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlHamburgerHolder;
        private System.Windows.Forms.PictureBox pbxHamburger;
        internal System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.FlowLayoutPanel flpSidebar;
        private System.Windows.Forms.FlowLayoutPanel flpBannerbar;
        private System.Windows.Forms.Panel pnlPageIndicatorHolder;
        private System.Windows.Forms.Label lblPageIndicator;
        private System.Windows.Forms.Panel pnlChildFormHolder;
    }
}
