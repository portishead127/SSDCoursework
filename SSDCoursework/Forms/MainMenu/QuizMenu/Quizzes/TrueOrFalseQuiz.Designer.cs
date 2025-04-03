namespace SSDCoursework.Forms.MainMenu.QuizMenu.Quizzes
{
    partial class TrueOrFalseQuiz
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.lblQNum = new System.Windows.Forms.Label();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pbxResponse = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.gameBannerControl1 = new SSDCoursework.UserControls.GameBannerControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbxResponse)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(214, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 109);
            this.button1.TabIndex = 0;
            this.button1.Text = "True";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAnswer1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(976, 600);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 109);
            this.button2.TabIndex = 3;
            this.button2.Text = "False";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAnswer2_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // lblQNum
            // 
            this.lblQNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblQNum.ForeColor = System.Drawing.Color.White;
            this.lblQNum.Location = new System.Drawing.Point(202, 162);
            this.lblQNum.Name = "lblQNum";
            this.lblQNum.Size = new System.Drawing.Size(956, 30);
            this.lblQNum.TabIndex = 14;
            this.lblQNum.Tag = "ButtonAccent";
            this.lblQNum.Text = "Question Text";
            this.lblQNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblQuestionText.ForeColor = System.Drawing.Color.White;
            this.lblQuestionText.Location = new System.Drawing.Point(202, 162);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(983, 165);
            this.lblQuestionText.TabIndex = 13;
            this.lblQuestionText.Tag = "ButtonAccent";
            this.lblQuestionText.Text = "Question Text";
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(1150, 103);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(233, 42);
            this.lblScore.TabIndex = 16;
            this.lblScore.Tag = "ButtonAccent";
            this.lblScore.Text = "Score: 0";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(2, 103);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(183, 42);
            this.lblTimer.TabIndex = 15;
            this.lblTimer.Tag = "ButtonAccent";
            this.lblTimer.Text = "Timer: 60";
            // 
            // pictureBox1
            // 
            this.pbxResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxResponse.Location = new System.Drawing.Point(1274, 148);
            this.pbxResponse.Name = "pictureBox1";
            this.pbxResponse.Size = new System.Drawing.Size(100, 100);
            this.pbxResponse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxResponse.TabIndex = 17;
            this.pbxResponse.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = global::SSDCoursework.Properties.Resources.LoginSymbol;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStart.Location = new System.Drawing.Point(490, 285);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.btnStart.Size = new System.Drawing.Size(408, 444);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "START";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gameBannerControl1
            // 
            this.gameBannerControl1.AutoSize = true;
            this.gameBannerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.gameBannerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameBannerControl1.Location = new System.Drawing.Point(0, 0);
            this.gameBannerControl1.Name = "gameBannerControl1";
            this.gameBannerControl1.Size = new System.Drawing.Size(1386, 100);
            this.gameBannerControl1.TabIndex = 6;
            // 
            // TrueOrFalseQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pbxResponse);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblQNum);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gameBannerControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQuestionText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrueOrFalseQuiz";
            this.Tag = "MainColour";
            this.Text = "True Or False";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbxResponse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer tmr;
        private UserControls.GameBannerControl gameBannerControl1;
        private System.Windows.Forms.Label lblQNum;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox pbxResponse;
    }
}