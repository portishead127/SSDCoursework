using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.QuestionClasses;
using SSDCoursework.Classes.UserClasses;
using SSDCoursework.Forms.Misc;
using SSDCoursework.Properties;
using System;
using System.Windows.Forms;

namespace SSDCoursework.Forms.MainMenu.QuizMenu.Quizzes
{
    public partial class MultipleChoiceQuiz : Form
    {
        Quiz quiz;
        MultipleChoiceQuestion currentQuestion;
        GameType gameType = GameType.MultipleChoice;
        Random rand = new Random();
        bool isGameOver;
        int currentQuestionIndex = -1;
        int score = 0;
        const int maxTime = 60;
        int remainingTime = maxTime;

        public MultipleChoiceQuiz()
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
            button3.Enabled = false;
            button3.Visible = false;
        }

        private void UpdateQuestion()
        {
            int correctAnswerPos = rand.Next(0, 3);
            if (currentQuestionIndex < Quiz.NumOfQuestions - 1)
            {
                currentQuestionIndex++;
                currentQuestion = (MultipleChoiceQuestion)quiz.Questions[currentQuestionIndex];
                lblQuestionText.Text = currentQuestion.QuestionTerm;
                lblQNum.Text = "Question " + (currentQuestionIndex + 1) + "/" + Quiz.NumOfQuestions;

                switch (correctAnswerPos)
                {
                    case 0:
                        button1.Text = currentQuestion.CorrectAnswer;
                        button2.Text = currentQuestion.FakeAnswers[0];
                        button3.Text = currentQuestion.FakeAnswers[1];
                        break;
                    case 1:
                        button1.Text = currentQuestion.FakeAnswers[0];
                        button2.Text = currentQuestion.CorrectAnswer;
                        button3.Text = currentQuestion.FakeAnswers[1];
                        break;
                    case 2:
                        button1.Text = currentQuestion.FakeAnswers[0];
                        button2.Text = currentQuestion.FakeAnswers[1];
                        button3.Text = currentQuestion.CorrectAnswer;
                        break;
                }
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
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";

            score += remainingTime;
            lblScore.Text = "Score: " + score;
            remainingTime = 0;
            lblTimer.Text = "Game Over!";

            btnStart.Text = "DONE!";

            btnStart.Enabled = true;
            btnStart.Visible = true;

            button1.Enabled = false;
            button1.Visible = false;
            button2.Enabled = false;
            button2.Visible = false;
            button3.Enabled = false;
            button3.Visible = false;
            lblQNum.Visible = false;
            lblQNum.Enabled = false;
            lblQuestionText.Visible = false;
            lblQuestionText.Enabled = false;

            btnStart.Visible = true;
            btnStart.Enabled = true;
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
            if (isGameOver)
            {
                EndOfQuiz();
                User.CurrentUser.Scorecard.UpdateScore(gameType, score);
                (Application.OpenForms[0] as SplashScreen).Reset(2, new MainMenuHolder());
            }
            else
            {
                tmr.Start();
                lblTimer.Text = "Remaining time: " + remainingTime.ToString();
                UpdateQuestion();
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
                button3.Enabled = true;
                button3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentQuestion.CheckAnswer(button1.Text))
            {
                score += 20;
                lblScore.Text = "Score: " + score;
                pictureBox1.Image = Properties.Resources.Tick;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.Incorrect;
            }
            UpdateQuestion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentQuestion.CheckAnswer(button2.Text))
            {
                score += 20;
                lblScore.Text = "Score: " + score;
                pictureBox1.Image = Properties.Resources.Tick;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.Incorrect;
            }
            UpdateQuestion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentQuestion.CheckAnswer(button3.Text))
            {
                score += 20;
                lblScore.Text = "Score: " + score;
                pictureBox1.Image = Properties.Resources.Tick;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.Incorrect;
            }
            UpdateQuestion();
        }
    }
}

