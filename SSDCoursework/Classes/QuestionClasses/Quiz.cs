using System;
using System.Collections.Generic;

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
        List<IQuestion> questions; //Questions can be of any type.
        int numOfQuestions;

        public Quiz(List<IQuestion> questions, DifficultyLevel difficultyLevel)
        {
            this.questions = questions;
            numOfQuestions = questions.Count;
            this.difficultyLevel = difficultyLevel;
        }

        public int NumOfQuestions
        {
            get { return numOfQuestions; }
        }

        public List<IQuestion> Questions
        {
            get { return questions; }
        }
    }
}
