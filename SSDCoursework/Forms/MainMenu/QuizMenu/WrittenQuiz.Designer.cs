namespace SSDCoursework.Forms.MainMenu.QuizMenu
{
    partial class WrittenQuiz
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
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.txtUserAnswer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.gmcBanner = new SSDCoursework.UserControls.GameBannerControl();
            this.SuspendLayout();
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Location = new System.Drawing.Point(351, 211);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(73, 13);
            this.lblQuestionText.TabIndex = 0;
            this.lblQuestionText.Text = "Question Text";
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUserAnswer.Location = new System.Drawing.Point(303, 261);
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(166, 20);
            this.txtUserAnswer.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.Location = new System.Drawing.Point(349, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(47, 132);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(36, 13);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "Timer:";
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(713, 102);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "button2";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(50, 167);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(47, 13);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score: 0";
            // 
            // gmcBanner
            // 
            this.gmcBanner.AutoSize = true;
            this.gmcBanner.Location = new System.Drawing.Point(0, 0);
            this.gmcBanner.Name = "gmcBanner";
            this.gmcBanner.Size = new System.Drawing.Size(1928, 96);
            this.gmcBanner.TabIndex = 2;
            // 
            // WrittenQuiz
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gmcBanner);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.lblQuestionText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WrittenQuiz";
            this.Text = "Written Quiz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.TextBox txtUserAnswer;
        private UserControls.GameBannerControl gmcBanner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblScore;
    }
}