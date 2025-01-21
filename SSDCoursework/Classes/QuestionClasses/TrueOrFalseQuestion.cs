using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal class TrueOrFalseQuestion : Question
    {
        public bool CorrectAnswer { get; }

        protected override object Answer => CorrectAnswer;

        public TrueOrFalseQuestion(string questionText, bool correctAnswer) : base(questionText)
        {
            CorrectAnswer = correctAnswer;
        }
    }
}
