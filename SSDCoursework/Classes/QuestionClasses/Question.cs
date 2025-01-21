using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal abstract class Question
    {
        protected string QuestionText { get; }
        protected abstract object Answer { get; }

        protected Question(string questionText)
        {
            QuestionText = questionText;
        }
    }
}
