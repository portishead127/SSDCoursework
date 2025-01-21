using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal class TrueOrFalseQuestion : Question<bool> 
    {
        public TrueOrFalseQuestion(string questionTerm, bool answer) : base(questionTerm, answer) { }
    }
}
