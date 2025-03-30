using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.QuestionClasses;
using SSDCoursework.Classes.UserClasses;
using SSDCoursework.Forms.Misc;
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

            //Updating visibility of assets
            lblQNum.Visible = false;
            lblQNum.Enabled = false;
            lblQuestionText.Visible = false;
            lblQuestionText.Enabled = false;
            btnAnswer1.Enabled = false;
            btnAnswer1.Visible = false;
            btnAnswer2.Enabled = false;
            btnAnswer2.Visible = false;
            btnAnswer3.Enabled = false;
            btnAnswer3.Visible = false;
        }

        /// <summary>
        /// Decides what space will have the correct answer and selects the next question in the quiz object, unless we are out of questions.
        /// </summary>
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
                        btnAnswer1.Text = currentQuestion.CorrectAnswer;
                        btnAnswer2.Text = currentQuestion.FakeAnswers[0];
                        btnAnswer3.Text = currentQuestion.FakeAnswers[1];
                        break;
                    case 1:
                        btnAnswer1.Text = currentQuestion.FakeAnswers[0];
                        btnAnswer2.Text = currentQuestion.CorrectAnswer;
                        btnAnswer3.Text = currentQuestion.FakeAnswers[1];
                        break;
                    case 2:
                        btnAnswer1.Text = currentQuestion.FakeAnswers[0];
                        btnAnswer2.Text = currentQuestion.FakeAnswers[1];
                        btnAnswer3.Text = currentQuestion.CorrectAnswer;
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
            btnAnswer1.Text = "";
            btnAnswer2.Text = "";
            btnAnswer3.Text = "";

            //Adjusting score labels
            score += remainingTime;
            lblScore.Text = "Score: " + score;
            remainingTime = 0;
            lblTimer.Text = "Game Over!";

            btnStart.Text = "DONE!";

            //Updates visibilty of assets
            btnStart.Enabled = true;
            btnStart.Visible = true;

            btnAnswer1.Enabled = false;
            btnAnswer1.Visible = false;
            btnAnswer2.Enabled = false;
            btnAnswer2.Visible = false;
            btnAnswer3.Enabled = false;
            btnAnswer3.Visible = false;
            lblQNum.Visible = false;
            lblQNum.Enabled = false;
            lblQuestionText.Visible = false;
            lblQuestionText.Enabled = false;
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
                (Application.OpenForms[0] as SplashScreen).Reset(2, new MainMenuHolder());
            }
            else
            {
                tmr.Start();
                lblTimer.Text = "Remaining time: " + remainingTime.ToString();
                UpdateQuestion();

                //Updating asset visibility
                btnStart.Enabled = false;
                btnStart.Visible = false;
                lblQNum.Visible = true;
                lblQNum.Enabled = true;
                lblQuestionText.Visible = true;
                lblQuestionText.Enabled = true;
                btnAnswer1.Enabled = true;
                btnAnswer1.Visible = true;
                btnAnswer2.Enabled = true;
                btnAnswer2.Visible = true;
                btnAnswer3.Enabled = true;
                btnAnswer3.Visible = true;
            }
        }

        //Marks answer 1
        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            if (currentQuestion.CheckAnswer(btnAnswer1.Text))
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

        //Marks answer 2
        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            if (currentQuestion.CheckAnswer(btnAnswer2.Text))
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

        //Marks answer 3
        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            if (currentQuestion.CheckAnswer(btnAnswer3.Text))
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

