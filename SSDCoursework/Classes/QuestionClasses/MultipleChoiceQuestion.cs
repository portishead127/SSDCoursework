using System;
using System.Linq;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal class MultipleChoiceQuestion : Question
    {
        public MultipleChoiceQuestion(string questionText, string correctAnswer, string[] fakeAnswers): base(questionText, correctAnswer, fakeAnswers) {}

        public new bool CheckAnswer(string userAnswer)
        {
            if (!FakeAnswers.Contains(userAnswer) && userAnswer != CorrectAnswer)
            {
                throw new Exception("Input was not one of the possible options.");
            }
            return base.CheckAnswer(userAnswer);
        }
    }
}
