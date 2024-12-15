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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SidebarControl));
            this.flpSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHamburgerHolder = new System.Windows.Forms.Panel();
            this.pbxHamburger = new System.Windows.Forms.PictureBox();
            this.lblHamburgerText = new System.Windows.Forms.Label();
            this.pnlChildFormHolder = new System.Windows.Forms.Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.flpSidebar.SuspendLayout();
            this.pnlHamburgerHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHamburger)).BeginInit();
            this.SuspendLayout();
            // 
            // flpSidebar
            // 
            this.flpSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.flpSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpSidebar.Controls.Add(this.pnlHamburgerHolder);
            this.flpSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpSidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSidebar.Location = new System.Drawing.Point(0, 0);
            this.flpSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.flpSidebar.MinimumSize = new System.Drawing.Size(68, 453);
            this.flpSidebar.Name = "flpSidebar";
            this.flpSidebar.Size = new System.Drawing.Size(68, 599);
            this.flpSidebar.TabIndex = 1;
            // 
            // pnlHamburgerHolder
            // 
            this.pnlHamburgerHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlHamburgerHolder.Controls.Add(this.pbxHamburger);
            this.pnlHamburgerHolder.Controls.Add(this.lblHamburgerText);
            this.pnlHamburgerHolder.Location = new System.Drawing.Point(0, 0);
            this.pnlHamburgerHolder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHamburgerHolder.Name = "pnlHamburgerHolder";
            this.pnlHamburgerHolder.Size = new System.Drawing.Size(67, 96);
            this.pnlHamburgerHolder.TabIndex = 0;
            // 
            // pbxHamburger
            // 
            this.pbxHamburger.BackColor = System.Drawing.Color.Transparent;
            this.pbxHamburger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHamburger.Image = ((System.Drawing.Image)(resources.GetObject("pbxHamburger.Image")));
            this.pbxHamburger.Location = new System.Drawing.Point(4, 5);
            this.pbxHamburger.Margin = new System.Windows.Forms.Padding(0);
            this.pbxHamburger.Name = "pbxHamburger";
            this.pbxHamburger.Size = new System.Drawing.Size(57, 60);
            this.pbxHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHamburger.TabIndex = 1;
            this.pbxHamburger.TabStop = false;
            this.pbxHamburger.Click += new System.EventHandler(this.pbxHamburger_Click);
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
            // pnlChildFormHolder
            // 
            this.pnlChildFormHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChildFormHolder.AutoSize = true;
            this.pnlChildFormHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.pnlChildFormHolder.Location = new System.Drawing.Point(68, 0);
            this.pnlChildFormHolder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlChildFormHolder.Name = "pnlChildFormHolder";
            this.pnlChildFormHolder.Size = new System.Drawing.Size(1764, 599);
            this.pnlChildFormHolder.TabIndex = 2;
            this.pnlChildFormHolder.Tag = "";
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 5;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // SidebarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.flpSidebar);
            this.Controls.Add(this.pnlChildFormHolder);
            this.Name = "SidebarControl";
            this.Size = new System.Drawing.Size(912, 599);
            this.Resize += new System.EventHandler(this.SidebarControl_Resize);
            this.flpSidebar.ResumeLayout(false);
            this.pnlHamburgerHolder.ResumeLayout(false);
            this.pnlHamburgerHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHamburger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlHamburgerHolder;
        private System.Windows.Forms.Label lblHamburgerText;
        private System.Windows.Forms.PictureBox pbxHamburger;
        private System.Windows.Forms.Panel pnlChildFormHolder;
        internal System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.FlowLayoutPanel flpSidebar;
    }
}
