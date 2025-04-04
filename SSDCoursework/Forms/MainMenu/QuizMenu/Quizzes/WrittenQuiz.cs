﻿using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.QuestionClasses;
using SSDCoursework.Forms.Misc;
using SSDCoursework.Classes.UserClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SSDCoursework.Forms.MainMenu.QuizMenu.Quizzes
{
    public partial class WrittenQuiz : Form
    {
        const GameType gameType = GameType.WrittenQuestion;
        Quiz quiz;
        WrittenQuestion currentQuestion;
        bool isGameOver;
        int currentQuestionIndex = -1;
        int score = 0;
        const int maxTime = 60;
        int remainingTime = maxTime;

        public WrittenQuiz()
        {
            InitializeComponent();
            isGameOver = false;
            lblQNum.Visible = false;
            lblQNum.Enabled = false;
            lblQuestionText.Visible = false;
            lblQuestionText.Enabled = false;
            txtUserAnswer.Visible = false;
            txtUserAnswer.Enabled = false;
            User.CurrentUser.Settings.ColourPalette.ApplyColour(this.Controls, this);
            quiz = new Quiz(gameType);
        }

        private void UpdateQuestion()
        {
            if (currentQuestionIndex < Quiz.NumOfQuestions - 1)
            {
                currentQuestionIndex++;
                currentQuestion = (WrittenQuestion)quiz.Questions[currentQuestionIndex];
                lblQNum.Text = "Question " + (currentQuestionIndex + 1) + " of " + Quiz.NumOfQuestions;
                lblQuestionText.Text = currentQuestion.QuestionTerm;
                txtUserAnswer.Text = "";
            }
            else
            {
                EndOfQuiz();
            }
        }

        private void EndOfQuiz()
        {
            tmr.Stop();
            isGameOver = true;
            lblQuestionText.Text = "Done";
            txtUserAnswer.Text = "";

            score += remainingTime;
            lblScore.Text = "Score: " + score;
            remainingTime = 0;
            lblTimer.Text = "Game Over!";

            txtUserAnswer.Enabled = false;
            txtUserAnswer.Visible = false;

            btnEnter.Enabled = false;
            btnEnter.Visible = false;

            btnStart.Visible = true;
            btnStart.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentQuestion.CheckAnswer(txtUserAnswer.Text))
            {
                score += 25;
                lblScore.Text = "Score: " + score;
                pictureBox1.Image = Properties.Resources.Tick;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.Incorrect;
            }

            UpdateQuestion();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (remainingTime == 0)
            {
                EndOfQuiz();
            }
            else
            {
                remainingTime--;
                lblTimer.Text = "Remaining time: " + remainingTime.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isGameOver)
            {
                User.CurrentUser.Scorecard.UpdateScore(gameType, score);
                (Application.OpenForms[0] as SplashScreen).Reset(3, new MainMenuHolder());
            }
            else
            {
                tmr.Start();
                lblTimer.Text = "Remaining time: " + remainingTime.ToString();
                UpdateQuestion();
                btnStart.Text = "DONE!";
                btnStart.Enabled = false;
                btnStart.Visible = false;
                btnEnter.Enabled = true;
                btnEnter.Visible = true;

                lblQNum.Visible = true;
                lblQNum.Enabled = true;
                lblQuestionText.Visible = true;
                lblQuestionText.Enabled = true;
                txtUserAnswer.Visible = true;
                txtUserAnswer.Enabled = true;
                txtUserAnswer.Focus();
            }
        }
    }
}