using SSDCoursework.Classes.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal class Quiz
    {
        const int numOfQuestions = 10;
        public List<Question> Questions { get; }
        public DifficultyLvl Difficulty { get; }

        public Quiz(DifficultyLvl difficulty)
        {
            Random rand = new Random();
            List<Question> shuffledEntries = QuestionDatabase.Instance.Entries.OrderBy(_ => rand.Next()).ToList();

            switch (difficulty)
            {
                case DifficultyLvl.TrueFalse:
                    Questions = shuffledEntries
                        .Select(question => new TrueOrFalseQuestion(question.TFQuestionTerm, question.TFCorrectAnswer))
                        .Take(numOfQuestions)
                        .Cast<Question>()
                        .ToList();
                    break;

                case DifficultyLvl.MultipleChoice:
                    Questions = shuffledEntries
                        .Select(question => new MultipleChoiceQuestion(question.QuestionTerm, question.CorrectAnswer, question.FakeAnswers))
                        .Take(numOfQuestions)
                        .Cast<Question>()
                        .ToList();
                    break;

                case DifficultyLvl.WrittenQuestion:
                    Questions = shuffledEntries
                        .Select(question => new WrittenQuestion(question.TFQuestionTerm, question.CorrectAnswer))
                        .Take(numOfQuestions)
                        .Cast<Question>()
                        .ToList();
                    break;

                default:
                    throw new Exception("Incorrect difficulty type.");
            }
            Difficulty = difficulty;
        }
    }
}
