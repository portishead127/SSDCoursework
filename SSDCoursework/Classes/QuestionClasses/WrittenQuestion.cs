using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal class WrittenQuestion : IQuestion
    {
        public string QuestionText { get; }
        public string CorrectAnswer {  get; }
        public object Answer => CorrectAnswer;

        public WrittenQuestion(string questionText, string correctAnswer)
        {
            QuestionText = questionText;
            CorrectAnswer = correctAnswer;
        }


    }
}
