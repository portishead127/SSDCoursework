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
            this.gameBannerControl1 = new SSDCoursework.UserControls.GameBannerControl();
            this.lblQNum = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Adobe Heiti Std R", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(214, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 109);
            this.button1.TabIndex = 0;
            this.button1.Text = "True";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Adobe Heiti Std R", 24F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(976, 600);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 109);
            this.button2.TabIndex = 3;
            this.button2.Text = "False";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // gameBannerControl1
            // 
            this.gameBannerControl1.AutoSize = true;
            this.gameBannerControl1.Location = new System.Drawing.Point(0, 0);
            this.gameBannerControl1.Name = "gameBannerControl1";
            this.gameBannerControl1.Size = new System.Drawing.Size(1928, 96);
            this.gameBannerControl1.TabIndex = 6;
            // 
            // lblQNum
            // 
            this.lblQNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQNum.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblQNum.ForeColor = System.Drawing.Color.White;
            this.lblQNum.Location = new System.Drawing.Point(134, 162);
            this.lblQNum.Name = "lblQNum";
            this.lblQNum.Size = new System.Drawing.Size(1115, 30);
            this.lblQNum.TabIndex = 14;
            this.lblQNum.Tag = "ButtonAccent";
            this.lblQNum.Text = "Question Text";
            this.lblQNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("Adobe Heiti Std R", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = global::SSDCoursework.Properties.Resources.LoginSymbol;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStart.Location = new System.Drawing.Point(490, 285);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.btnStart.Size = new System.Drawing.Size(408, 462);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "START";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuestionText.Font = new System.Drawing.Font("Adobe Heiti Std R", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblQuestionText.ForeColor = System.Drawing.Color.White;
            this.lblQuestionText.Location = new System.Drawing.Point(134, 162);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(1115, 165);
            this.lblQuestionText.TabIndex = 13;
            this.lblQuestionText.Tag = "ButtonAccent";
            this.lblQuestionText.Text = "Question Text";
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScore.Font = new System.Drawing.Font("Adobe Heiti Std R", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(1187, 99);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(194, 34);
            this.lblScore.TabIndex = 16;
            this.lblScore.Tag = "ButtonAccent";
            this.lblScore.Text = "Score: 0";
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Adobe Heiti Std R", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTimer.Location = new System.Drawing.Point(12, 99);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(135, 34);
            this.lblTimer.TabIndex = 15;
            this.lblTimer.Tag = "ButtonAccent";
            this.lblTimer.Text = "Timer: 60";
            // 
            // TrueOrFalseQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
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
            this.Text = "TrueOrFalseQuiz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}