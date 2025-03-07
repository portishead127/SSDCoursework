using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.QuestionClasses;
using SSDCoursework.Classes.UserClasses;
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

namespace SSDCoursework.Forms.MainMenu.QuizMenu.Quizzes
{
    public partial class TrueOrFalseQuiz : Form
    {
        GameType gameType = GameType.TrueFalse;
        Quiz quiz;
        TrueOrFalseQuestion currentQuestion;
        int currentQuestionIndex = -1;
        int score = 0;
        const int maxTime = 60;
        int remainingTime = maxTime;

        public TrueOrFalseQuiz()
        {
            InitializeComponent();
            quiz = new Quiz(gameType);
            User.CurrentUser.Settings.ColourPalette.ApplyColour(this.Controls, this);
            lblQNum.Visible = false;
            lblQNum.Enabled = false;
            lblQuestionText.Visible = false;
            lblQuestionText.Enabled = false;
            button1.Enabled = false;
            button1.Visible = false;
            button2.Enabled = false;
            button2.Visible = false;
        }

        private void UpdateQuestion()
        {
            if (currentQuestionIndex < Quiz.NumOfQuestions - 1)
            {
                currentQuestionIndex++;
                currentQuestion = (TrueOrFalseQuestion)quiz.Questions[currentQuestionIndex];
                lblQuestionText.Text = currentQuestion.TFQuestionTerm;
                lblQNum.Text = "Question " + (currentQuestionIndex + 1) + "/" + Quiz.NumOfQuestions;
            }
            else
            {
                EndOfQuiz();
            }
        }

        private void EndOfQuiz()
        {
            tmr.Stop();
            lblQuestionText.Text = "Done";

            score += remainingTime;
            lblScore.Text = "Score: " + score;
            remainingTime = 0;
            lblTimer.Text = "Remaining time: " + 0.ToString();

            button1.Enabled = false;
            button1.Visible = false;

            button2.Enabled = false;
            button2.Visible = false;

            lblQNum.Visible = false;
            lblQNum.Enabled = false;

            lblQuestionText.Visible = false;
            lblQuestionText.Enabled = false;

            btnStart.Visible = true;
            btnStart.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentQuestion.CheckAnswer(true))
            {
                score += 1;
                lblScore.Text = "Score: " + score;
            }
            UpdateQuestion();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (remainingTime == 0)
            {
                EndOfQuiz();
            }
            remainingTime--;
            lblTimer.Text = "Remaining time: " + remainingTime.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (remainingTime == 0)
            {
                (Application.OpenForms[0] as SplashScreen).Reset(3, new MainMenuHolder());
                User.CurrentUser.Scorecard.UpdateScore(gameType, score);
            }
            tmr.Start();
            lblTimer.Text = "Remaining time: " + remainingTime.ToString();
            UpdateQuestion();
            btnStart.Text = "DONE!";
            btnStart.Enabled = false;
            btnStart.Visible = false;
            lblQNum.Visible = true;
            lblQNum.Enabled = true;
            lblQuestionText.Visible = true;
            lblQuestionText.Enabled = true;
            button1.Enabled = true;
            button1.Visible = true;
            button2.Enabled = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentQuestion.CheckAnswer(false))
            {
                score += 1;
                lblScore.Text = "Score: " + score;
            }
            UpdateQuestion();
        }
    }
}
