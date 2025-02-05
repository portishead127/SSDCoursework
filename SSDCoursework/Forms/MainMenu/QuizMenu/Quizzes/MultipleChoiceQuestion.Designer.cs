namespace SSDCoursework.Forms.MainMenu.QuizMenu.Quizzes
{
    partial class MultipleChoiceQuiz
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.gameBannerControl1 = new SSDCoursework.UserControls.GameBannerControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(634, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(713, 102);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "button4";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(12, 99);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(33, 13);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "Timer";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(15, 116);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 13);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score: ";
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Location = new System.Drawing.Point(355, 142);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(35, 13);
            this.lblQuestionText.TabIndex = 7;
            this.lblQuestionText.Text = "label1";
            // 
            // gameBannerControl1
            // 
            this.gameBannerControl1.AutoSize = true;
            this.gameBannerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameBannerControl1.Location = new System.Drawing.Point(0, 0);
            this.gameBannerControl1.Name = "gameBannerControl1";
            this.gameBannerControl1.Size = new System.Drawing.Size(800, 96);
            this.gameBannerControl1.TabIndex = 0;
            // 
            // MultipleChoiceQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gameBannerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MultipleChoiceQuiz";
            this.Text = "MultipleChoiceQuiz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.GameBannerControl gameBannerControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label lblQuestionText;
    }
}