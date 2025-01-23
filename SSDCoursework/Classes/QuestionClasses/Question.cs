﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework.Classes.QuestionClasses
{
    // Outside of the class so it can be referenced by the Quiz class too.
    public enum DifficultyLvl
    {
        TrueFalse,
        MultipleChoice,
        WrittenQuestion
    }

    internal class Question
    {
        public string QuestionTerm { get; }
        public string CorrectAnswer { get; }

        public string[] FakeAnswers { get; }
        
        public string TFQuestionTerm { get; }
        public bool TFCorrectAnswer { get; }

        public DifficultyLvl Difficulty { get; protected set; }
        public object UserAnswer { get; protected set; }

        /// <summary>
        /// Written question constructor
        /// </summary>
        /// <param name="questionTerm"></param>
        /// <param name="correctAnswer"></param>
        protected Question(string questionTerm, string correctAnswer)
        {
            QuestionTerm = questionTerm;
            CorrectAnswer = correctAnswer;
        }

        /// <summary>
        /// Multiple choice question constructor
        /// </summary>
        /// <param name="questionTerm"></param>
        /// <param name="correctAnswer"></param>
        /// <param name="fakeAnswers"></param>
        protected Question(string questionTerm, string correctAnswer, string[] fakeAnswers)
        {
            QuestionTerm = questionTerm;
            CorrectAnswer = correctAnswer;
            FakeAnswers = fakeAnswers;
        }

        /// <summary>
        /// True or false question constructor
        /// </summary>
        /// <param name="tfQuestionTerm"></param>
        /// <param name="tfCorrectAnswer"></param>
        protected Question(string tfQuestionTerm, bool tfCorrectAnswer)
        {
            TFQuestionTerm = tfQuestionTerm;
            TFCorrectAnswer = tfCorrectAnswer;
        }

        public Question(string questionTerm, string correctAnswer, string[] fakeAnswers, string tFQuestionTerm, bool tFCorrectAnswer) 
        {
            QuestionTerm = questionTerm;
            CorrectAnswer = correctAnswer;
            FakeAnswers = fakeAnswers;
            TFQuestionTerm = tFQuestionTerm;
            TFCorrectAnswer = tFCorrectAnswer;
        }

        public bool CheckAnswer(string userAnswer)
        {
            UserAnswer = userAnswer;
            if((string)UserAnswer == CorrectAnswer)
            {
                return true;
            }
            return false;
        }

        public bool CheckAnswer(bool userAnswer)
        {
            UserAnswer = userAnswer;
            if ((bool)UserAnswer == TFCorrectAnswer)
            {
                return true;
            }
            return false;
        }
    }
}
