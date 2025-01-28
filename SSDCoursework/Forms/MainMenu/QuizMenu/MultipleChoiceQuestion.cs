using SSDCoursework.Classes.QuestionClasses;
using SSDCoursework.Forms.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework.Forms.MainMenu.QuizMenu
{
    public partial class MultipleChoiceQuiz : Form
    {
        Quiz quiz;
        Question currentQuestion;
        int currentQuestionIndex = -1;
        int score = 0;
        const int maxTime = 60;
        int remainingTime = maxTime;

        public MultipleChoiceQuiz()
        {
            InitializeComponent();
            quiz = new Quiz(DifficultyLvl.MultipleChoice);
        }

        private void UpdateQuestion()
        {
            Random rand = new Random();
            int correctAnswerPos = rand.Next(0, 3);
            if (currentQuestionIndex < Quiz.NumOfQuestions - 1)
            {
                currentQuestionIndex++;
                currentQuestion = quiz.Questions[currentQuestionIndex];
                lblQuestionText.Text = currentQuestion.QuestionTerm;

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
            lblQuestionText.Text = "Done";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";

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
            if (currentQuestion.CheckAnswer(button1.Text))
            {
                score += 2;
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
            lblTimer.Text = remainingTime.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (remainingTime == 0)
            {
                (Application.OpenForms[0] as SplashScreen).Reset(2, new MainMenuHolder());
            }
            tmr.Start();
            lblTimer.Text = remainingTime.ToString();
            UpdateQuestion();
            btnStart.Enabled = false;
            btnStart.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentQuestion.CheckAnswer(button2.Text))
            {
                score += 2;
                lblScore.Text = "Score: " + score;
            }
            UpdateQuestion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentQuestion.CheckAnswer(button3.Text))
            {
                score += 2;
                lblScore.Text = "Score: " + score; 
            }
        }
    }
}

