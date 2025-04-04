﻿namespace SSDCoursework.Forms.MainMenu.QuizMenu.Quizzes
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblQNum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gmcBanner = new SSDCoursework.UserControls.GameBannerControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblQuestionText.ForeColor = System.Drawing.Color.White;
            this.lblQuestionText.Location = new System.Drawing.Point(136, 267);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(1115, 193);
            this.lblQuestionText.TabIndex = 0;
            this.lblQuestionText.Tag = "ButtonAccent";
            this.lblQuestionText.Text = "Question Text";
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.AcceptsReturn = true;
            this.txtUserAnswer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUserAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtUserAnswer.Location = new System.Drawing.Point(392, 657);
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(521, 38);
            this.txtUserAnswer.TabIndex = 1;
            this.txtUserAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEnter.Location = new System.Drawing.Point(919, 657);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(38, 38);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Tag = "ButtonAccent";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Visible = false;
            this.btnEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTimer.Location = new System.Drawing.Point(3, 103);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(137, 31);
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
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = global::SSDCoursework.Properties.Resources.LoginSymbol;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStart.Location = new System.Drawing.Point(489, 189);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.btnStart.Size = new System.Drawing.Size(408, 462);
            this.btnStart.TabIndex = 5;
            this.btnStart.Tag = "ButtonAccent";
            this.btnStart.Text = "START";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(1164, 111);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(219, 34);
            this.lblScore.TabIndex = 6;
            this.lblScore.Tag = "ButtonAccent";
            this.lblScore.Text = "Score: 0";
            // 
            // lblQNum
            // 
            this.lblQNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblQNum.ForeColor = System.Drawing.Color.White;
            this.lblQNum.Location = new System.Drawing.Point(142, 203);
            this.lblQNum.Name = "lblQNum";
            this.lblQNum.Size = new System.Drawing.Size(1115, 30);
            this.lblQNum.TabIndex = 7;
            this.lblQNum.Tag = "ButtonAccent";
            this.lblQNum.Text = "Question Text";
            this.lblQNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(1274, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // gmcBanner
            // 
            this.gmcBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.gmcBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.gmcBanner.Location = new System.Drawing.Point(0, 0);
            this.gmcBanner.Name = "gmcBanner";
            this.gmcBanner.Size = new System.Drawing.Size(1386, 100);
            this.gmcBanner.TabIndex = 2;
            // 
            // WrittenQuiz
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.gmcBanner);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.lblQNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WrittenQuiz";
            this.Tag = "MainColour";
            this.Text = "Written Quiz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.TextBox txtUserAnswer;
        private UserControls.GameBannerControl gmcBanner;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblQNum;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}