using SSDCoursework.Classes.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal class Quiz
    {
        public const int NumOfQuestions = 5;
        public List<Question> Questions { get; }
        public GameType GameType { get; }

        public Quiz(GameType gameType)
        {
            Random rand = new Random();
            List<Question> shuffledEntries = QuestionDatabase.Instance.Entries.OrderBy(_ => rand.Next()).ToList();

            switch (gameType)
            {
                case GameType.TrueFalse:
                    Questions = shuffledEntries
                        .Select(question => new TrueOrFalseQuestion(question.TFQuestionTerm, question.TFCorrectAnswer))
                        .Take(NumOfQuestions)
                        .Cast<Question>()
                        .ToList();
                    break;

                case GameType.MultipleChoice:
                    Questions = shuffledEntries
                        .Select(question => new MultipleChoiceQuestion(question.QuestionTerm, question.CorrectAnswer, question.FakeAnswers))
                        .Take(NumOfQuestions)
                        .Cast<Question>()
                        .ToList();
                    break;

                case GameType.WrittenQuestion:
                    Questions = shuffledEntries
                        .Select(question => new WrittenQuestion(question.QuestionTerm, question.CorrectAnswer))
                        .Take(NumOfQuestions)
                        .Cast<Question>()
                        .ToList();
                    break;

                default:
                    throw new Exception("Incorrect difficulty type.");
            }
            GameType = gameType;
        }
    }
}
