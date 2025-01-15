namespace SSDCoursework.Forms
{
    partial class SplashScreen
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
            this.pbxStemLogo = new System.Windows.Forms.PictureBox();
            this.pgrLoadingBar = new System.Windows.Forms.ProgressBar();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStemLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxStemLogo
            // 
            this.pbxStemLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxStemLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxStemLogo.Image = global::SSDCoursework.Properties.Resources.StemLogo;
            this.pbxStemLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxStemLogo.Name = "pbxStemLogo";
            this.pbxStemLogo.Size = new System.Drawing.Size(800, 450);
            this.pbxStemLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxStemLogo.TabIndex = 0;
            this.pbxStemLogo.TabStop = false;
            // 
            // pgrLoadingBar
            // 
            this.pgrLoadingBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgrLoadingBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.pgrLoadingBar.Location = new System.Drawing.Point(158, 375);
            this.pgrLoadingBar.Margin = new System.Windows.Forms.Padding(0);
            this.pgrLoadingBar.Name = "pgrLoadingBar";
            this.pgrLoadingBar.Size = new System.Drawing.Size(484, 23);
            this.pgrLoadingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgrLoadingBar.TabIndex = 1;
            // 
            // tmrSplash
            // 
            this.tmrSplash.Interval = 50;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // lblTagline
            // 
            this.lblTagline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTagline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagline.ForeColor = System.Drawing.Color.White;
            this.lblTagline.Location = new System.Drawing.Point(0, 351);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(800, 24);
            this.lblTagline.TabIndex = 2;
            this.lblTagline.Text = "Tagline";
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(301, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(199, 55);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "ROOTS";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTagline);
            this.Controls.Add(this.pgrLoadingBar);
            this.Controls.Add(this.pbxStemLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbxStemLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxStemLogo;
        private System.Windows.Forms.ProgressBar pgrLoadingBar;
        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblTitle;
    }
}