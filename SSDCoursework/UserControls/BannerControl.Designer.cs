namespace SSDCoursework.UserControls
{
    partial class GameBannerControl
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
            this.lblGameIndicator = new System.Windows.Forms.Label();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.flpBannerbar = new System.Windows.Forms.FlowLayoutPanel();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            this.flpBannerbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGameIndicator
            // 
            this.lblGameIndicator.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameIndicator.ForeColor = System.Drawing.Color.White;
            this.lblGameIndicator.Location = new System.Drawing.Point(3, 0);
            this.lblGameIndicator.Name = "lblGameIndicator";
            this.lblGameIndicator.Size = new System.Drawing.Size(1213, 96);
            this.lblGameIndicator.TabIndex = 0;
            this.lblGameIndicator.Text = "Current Game";
            this.lblGameIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbxExit
            // 
            this.pbxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxExit.Image = global::SSDCoursework.Properties.Resources.StemLogo;
            this.pbxExit.Location = new System.Drawing.Point(1222, 3);
            this.pbxExit.Name = "pbxExit";
            this.pbxExit.Size = new System.Drawing.Size(87, 75);
            this.pbxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxExit.TabIndex = 1;
            this.pbxExit.TabStop = false;
            this.pbxExit.Click += new System.EventHandler(this.pbxExit_Click);
            // 
            // flpBannerbar
            // 
            this.flpBannerbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.flpBannerbar.Controls.Add(this.lblGameIndicator);
            this.flpBannerbar.Controls.Add(this.pbxExit);
            this.flpBannerbar.Location = new System.Drawing.Point(0, 0);
            this.flpBannerbar.Margin = new System.Windows.Forms.Padding(0);
            this.flpBannerbar.Name = "flpBannerbar";
            this.flpBannerbar.Size = new System.Drawing.Size(1928, 96);
            this.flpBannerbar.TabIndex = 3;
            // 
            // GameBannerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flpBannerbar);
            this.Name = "GameBannerControl";
            this.Size = new System.Drawing.Size(1928, 96);
            this.Load += new System.EventHandler(this.GameBannerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            this.flpBannerbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxExit;
        private System.Windows.Forms.FlowLayoutPanel flpBannerbar;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label lblGameIndicator;
    }
}
