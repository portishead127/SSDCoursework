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
        bool isGameOver;
        int currentQuestionIndex = -1;
        int score = 0;
        const int maxTime = 60;
        int remainingTime = maxTime;

        public TrueOrFalseQuiz()
        {
            InitializeComponent();
            quiz = new Quiz(gameType);
            User.CurrentUser.Settings.ColourPalette.ApplyColour(this.Controls, this);
            isGameOver = false;

            lblQNum.Visible = false;
            lblQNum.Enabled = false;
            lblQuestionText.Visible = false;
            lblQuestionText.Enabled = false;
            button1.Enabled = false;
            button1.Visible = false;
            button2.Enabled = false;
            button2.Visible = false;
        }

        /// <summary>
        /// Loads next question if we aren't at the end of the quiz.
        /// </summary>
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
            lblTimer.Text = "Game over!";

            isGameOver = true;

            //Visibility of assets
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

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            if (currentQuestion.CheckAnswer(true))
            {
                score += 15;
                lblScore.Text = "Score: " + score;
                pbxResponse.Image = Properties.Resources.Tick;
            }
            else
            {
                pbxResponse.Image = Properties.Resources.Incorrect;
            }
            UpdateQuestion();
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            if (currentQuestion.CheckAnswer(false))
            {
                score += 15;
                lblScore.Text = "Score: " + score;
                pbxResponse.Image = Properties.Resources.Tick;
            }
            else
            {
                pbxResponse.Image = Properties.Resources.Incorrect;
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

        /// <summary>
        /// Updates the score if the game is over. Otherwise starts the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                //Setting visibility of assets
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
        }
    }
}
