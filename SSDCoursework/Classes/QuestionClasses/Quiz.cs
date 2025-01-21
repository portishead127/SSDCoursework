using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal class Quiz
    {
        public enum DifficultyLevel
        {
            Easy,
            Medium,
            Hard
        }

        DifficultyLevel difficultyLevel;
        List<Question> questions; //Questions can be of any type.
        int numOfQuestions;

        public Quiz(List<Question> questions, DifficultyLevel difficultyLevel)
        {
            this.questions = questions;
            numOfQuestions = questions.Count;
            this.difficultyLevel = difficultyLevel;
        }

        public int NumOfQuestions
        {
            get { return numOfQuestions; }
        }

        public List<Question> Questions
        {
            get { return questions; }
        }
    }
}
