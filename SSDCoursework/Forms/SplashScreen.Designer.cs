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
            ((System.ComponentModel.ISupportInitialize)(this.pbxStemLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxStemLogo
            // 
            this.pbxStemLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxStemLogo.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pgrLoadingBar);
            this.Controls.Add(this.pbxStemLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbxStemLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxStemLogo;
        private System.Windows.Forms.ProgressBar pgrLoadingBar;
        private System.Windows.Forms.Timer tmrSplash;
    }
}