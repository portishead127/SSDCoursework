using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal class TrueOrFalseQuestion : IQuestion
    {
        public string QuestionText { get; }
        public bool CorrectAnswer { get; }

        public object Answer => CorrectAnswer;

        public TrueOrFalseQuestion(string questionText, bool correctAnswer)
        {
            QuestionText = questionText;
            CorrectAnswer = correctAnswer;
        }
    }
}
