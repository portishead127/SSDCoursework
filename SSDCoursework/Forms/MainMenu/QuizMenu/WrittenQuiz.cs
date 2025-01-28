﻿using SSDCoursework.Classes.QuestionClasses;
using SSDCoursework.Forms.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SSDCoursework.Forms.MainMenu.QuizMenu
{
    public partial class WrittenQuiz : Form
    {
        Quiz quiz;
        Question currentQuestion;
        int currentQuestionIndex = -1;
        int score = 0;
        const int maxTime = 60;
        int remainingTime = maxTime;

        public WrittenQuiz()
        {
            InitializeComponent();
            quiz = new Quiz(DifficultyLvl.WrittenQuestion);
        }

        private void UpdateQuestion()
        {
            if(currentQuestionIndex < Quiz.NumOfQuestions - 1)
            {
                currentQuestionIndex++;
                currentQuestion = quiz.Questions[currentQuestionIndex];
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
            lblQuestionText.Text = "Done";
            txtUserAnswer.Text = "";

            score += remainingTime;
            lblScore.Text = "Score: " + score;
            remainingTime = 0;
            lblTimer.Text = 0.ToString();

            tmr.Stop();
            button1.Enabled = false;
            button1.Visible = false;

            btnStart.Visible = true;
            btnStart.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentQuestion.CheckAnswer(txtUserAnswer.Text))
            {
                score += 3;
                lblScore.Text = "Score: " + score;
            }
            UpdateQuestion();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if(remainingTime == 0)
            {
                EndOfQuiz();
            }
            remainingTime--;
            lblTimer.Text = remainingTime.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(remainingTime == 0)
            {
                (Application.OpenForms[0] as SplashScreen).Reset(3, new MainMenuHolder());
            }
            tmr.Start();
            lblTimer.Text = remainingTime.ToString();
            UpdateQuestion();
            btnStart.Enabled = false;
            btnStart.Visible = false;
        }
    }
}
