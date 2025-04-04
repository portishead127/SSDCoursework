﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string tfQuestionText, bool tfCorrectAnswer) : base(tfQuestionText, tfCorrectAnswer){}

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
