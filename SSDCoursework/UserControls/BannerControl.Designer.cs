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
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGameIndicator = new System.Windows.Forms.Label();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.pbxExit);
            this.panel1.Controls.Add(this.lblGameIndicator);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1927, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblGameIndicator
            // 
            this.lblGameIndicator.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameIndicator.ForeColor = System.Drawing.Color.White;
            this.lblGameIndicator.Location = new System.Drawing.Point(62, 0);
            this.lblGameIndicator.Name = "lblGameIndicator";
            this.lblGameIndicator.Size = new System.Drawing.Size(1213, 96);
            this.lblGameIndicator.TabIndex = 2;
            this.lblGameIndicator.Text = "Current Game";
            this.lblGameIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbxExit
            // 
            this.pbxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxExit.Image = global::SSDCoursework.Properties.Resources.close_1_;
            this.pbxExit.Location = new System.Drawing.Point(1787, 10);
            this.pbxExit.Name = "pbxExit";
            this.pbxExit.Size = new System.Drawing.Size(87, 75);
            this.pbxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxExit.TabIndex = 3;
            this.pbxExit.TabStop = false;
            this.pbxExit.Click += new System.EventHandler(this.pbxExit_Click);
            // 
            // GameBannerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "GameBannerControl";
            this.Size = new System.Drawing.Size(1928, 100);
            this.Load += new System.EventHandler(this.GameBannerControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGameIndicator;
        private System.Windows.Forms.PictureBox pbxExit;
    }
}
