using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal class MultipleChoiceQuestion : Question
    {
        public string CorrectAnswer { get; }
        public string FakeAnswer1 { get; }
        public string FakeAnswer2 { get; }

        protected override object Answer => CorrectAnswer;

        public MultipleChoiceQuestion(string questionText, string correctAnswer, string fakeAnswer1, string fakeAnswer2) : base(questionText)
        {
            CorrectAnswer = correctAnswer;
            FakeAnswer1 = fakeAnswer1;
            FakeAnswer2 = fakeAnswer2;
        }
    }
}
