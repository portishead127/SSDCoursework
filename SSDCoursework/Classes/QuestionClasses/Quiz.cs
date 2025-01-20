using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal class Quiz
    {
        List<Question<object>> questions; //Questions can be of any type.
        int numOfQuestions;
        int numOfQuestionsAnswered;
        int numOfQuestionsAnsweredCorrectly;

        public Quiz(List<Question<object>> questions)
        {
            this.questions = questions;
            numOfQuestions = questions.Count;
        }

        public int NumOfQuestions
        {
            get { return numOfQuestions; }
        }

        public List<Question<object>> Questions
        {
            get { return questions; }
        }
    }
}
