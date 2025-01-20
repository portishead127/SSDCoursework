using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal class MultipleChoiceQuestion : Question<string>
    {
        string fakeAnswer1;
        string fakeAnswer2;

        public MultipleChoiceQuestion(string questionTerm, string answer, string fakeAnswer1, string fakeAnswer2) : base(questionTerm, answer)
        {
            this.fakeAnswer1 = fakeAnswer1;
            this.fakeAnswer2 = fakeAnswer2;
        }

        public string FakeAnswer1
        {
            get { return fakeAnswer1; }
        }

        public string FakeAnswer2
        {
            get { return fakeAnswer2; }
        }
    }
}
