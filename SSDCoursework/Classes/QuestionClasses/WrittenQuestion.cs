using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal class WrittenQuestion : Question<string>
    {
        public WrittenQuestion(string questionTerm, string answer):base(questionTerm, answer) { }
    }
}
