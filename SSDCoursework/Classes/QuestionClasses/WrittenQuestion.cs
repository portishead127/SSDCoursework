using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal class WrittenQuestion : Question
    {
        public string CorrectAnswer {  get; }

        public WrittenQuestion(string questionText, string correctAnswer) : base(questionText)
        {
            CorrectAnswer = correctAnswer;
        }

        protected override object Answer => CorrectAnswer;
    }
}
