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
    public partial class QuizMenuHolder : Form
    {
        public QuizMenuHolder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (Application.OpenForms[0] as SplashScreen).Reset(5, new WrittenQuiz());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (Application.OpenForms[0] as SplashScreen).Reset(5, new WrittenQuiz());
        }
    }
}
