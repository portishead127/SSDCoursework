using SSDCoursework.Classes.UserClasses;
using SSDCoursework.Forms.MainMenu.QuizMenu.Quizzes;
using SSDCoursework.Forms.Misc;
using System;
using System.Windows.Forms;

namespace SSDCoursework.Forms.MainMenu.QuizMenu
{
    public partial class QuizMenuHolder : Form
    {
        public QuizMenuHolder()
        {
            InitializeComponent();
            User.CurrentUser.Settings.ColourPalette.ApplyColour(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            (Application.OpenForms[0] as SplashScreen).Reset(5, new MultipleChoiceQuiz());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (Application.OpenForms[0] as SplashScreen).Reset(5, new TrueOrFalseQuiz());
        }
    }
}
