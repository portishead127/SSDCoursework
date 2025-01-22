namespace SSDCoursework.Classes.QuestionClasses
{
    internal class MultipleChoiceQuestion : IQuestion
    {
        public string QuestionText { get; }
        public string CorrectAnswer { get; }
        public string FakeAnswer1 { get; }
        public string FakeAnswer2 { get; }

        public object Answer => CorrectAnswer;

        public MultipleChoiceQuestion(string questionText, string correctAnswer, string fakeAnswer1, string fakeAnswer2)
        {
            QuestionText = questionText;            
            CorrectAnswer = correctAnswer;
            FakeAnswer1 = fakeAnswer1;
            FakeAnswer2 = fakeAnswer2;
        }
    }
}
