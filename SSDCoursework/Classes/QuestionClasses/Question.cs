using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal abstract class Question<T>
    {
        string questionTerm;
        T answer;
        T userAnswer; //This is kept in case I want to reference the user's answer later on.

        public string QuestionTerm 
        { 
            get { return questionTerm; } 
        }

        public T Answer
        {
            get { return answer; }
        }

        public Question(string questionTerm, T answer)
        {
            this.questionTerm = questionTerm;
            this.answer = answer;
        }

        public T UserAnswer
        {
            get { return userAnswer; }
            set
            {
                if (GetType() == typeof(MultipleChoiceQuestion))
                {
                    MultipleChoiceQuestion thisMultipleChoiceQuestion = this as MultipleChoiceQuestion;
                    //If it's a multiple choice question, the answer needs to be one of the options.
                    if (value as string == thisMultipleChoiceQuestion.FakeAnswer1 || value as string == thisMultipleChoiceQuestion.FakeAnswer2 || value as string == thisMultipleChoiceQuestion.Answer)
                    {
                        userAnswer = value;
                    }
                }
                else
                {
                    userAnswer = value;
                }
            }
        }

        public void SelectUserAnswer(T userAnswer)
        {
            this.userAnswer = userAnswer;
            CheckAnswer();
        }

        protected bool CheckAnswer()
        {
            if (answer.Equals(userAnswer))
            {
                return true;
            }
            return false;
        }
    }
}
