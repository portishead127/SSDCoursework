namespace SSDCoursework.Forms.MainMenu.QuizMenu.Quizzes
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
            this.lblQNum = new System.Windows.Forms.Label();
            this.gmcBanner = new SSDCoursework.UserControls.GameBannerControl();
            this.SuspendLayout();
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuestionText.Font = new System.Drawing.Font("Adobe Heiti Std R", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblQuestionText.ForeColor = System.Drawing.Color.White;
            this.lblQuestionText.Location = new System.Drawing.Point(136, 267);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(1115, 165);
            this.lblQuestionText.TabIndex = 0;
            this.lblQuestionText.Tag = "ButtonAccent";
            this.lblQuestionText.Text = "Question Text";
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUserAnswer.Font = new System.Drawing.Font("Adobe Heiti Std R", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtUserAnswer.Location = new System.Drawing.Point(433, 657);
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(521, 61);
            this.txtUserAnswer.TabIndex = 1;
            this.txtUserAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserAnswer_KeyPress);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.Location = new System.Drawing.Point(1201, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 361);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Adobe Heiti Std R", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTimer.Location = new System.Drawing.Point(12, 111);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(135, 34);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Tag = "ButtonAccent";
            this.lblTimer.Text = "Timer: 60";
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("Adobe Heiti Std R", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = global::SSDCoursework.Properties.Resources.LoginSymbol;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStart.Location = new System.Drawing.Point(495, 314);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.btnStart.Size = new System.Drawing.Size(408, 462);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "START";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Adobe Heiti Std R", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(1257, 111);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(117, 34);
            this.lblScore.TabIndex = 6;
            this.lblScore.Tag = "ButtonAccent";
            this.lblScore.Text = "Score: 0";
            // 
            // lblQNum
            // 
            this.lblQNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQNum.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblQNum.ForeColor = System.Drawing.Color.White;
            this.lblQNum.Location = new System.Drawing.Point(142, 203);
            this.lblQNum.Name = "lblQNum";
            this.lblQNum.Size = new System.Drawing.Size(1115, 30);
            this.lblQNum.TabIndex = 7;
            this.lblQNum.Tag = "ButtonAccent";
            this.lblQNum.Text = "Question Text";
            this.lblQNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gmcBanner);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.lblQNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WrittenQuiz";
            this.Tag = "MainColour";
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
        private System.Windows.Forms.Label lblQNum;
    }
}