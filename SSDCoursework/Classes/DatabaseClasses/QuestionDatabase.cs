using SSDCoursework.Classes.QuestionClasses;
using System;
using System.Collections.Generic;
using System.IO;


namespace SSDCoursework.Classes.DatabaseClasses
{
    // Outside of the class so it can be referenced by the Quiz class too.
    public enum GameType
    {
        Unset,
        TrueFalse,
        MultipleChoice,
        WrittenQuestion
    }

    internal class QuestionDatabase : Database<Question>
    {
        public static QuestionDatabase Instance { get; private set; }

        static List<Question> defaultQuestions = new List<Question>()
        {
            new Question("What is the powerhouse of the cell?", "Mitochondria", new string[] {"Nucleus", "Ribosome" }, "The Mitochondria is the powerhouse of the cell.", true),
            new Question("Which gas do plants primarily take in during photosynthesis?", "Carbon dioxide", new string[] {"Oxygen", "Nitrogen" }, "Plants normally take in Nitrogen during photosynthesis.", false),
            new Question("What is the square root of 64?", "8", new string[] { "6", "7" }, "8 is the square root of 64", true),
            new Question("Which planet has the most moons?", "Saturn", new string[] { "Jupiter", "Mars" }, "Mars is the planet with the most moons in our solar system.", false),
            new Question("What is the freezing point of water in Celsius?", "0", new string[] { "100", "-10" }, "0 degrees Celcius is the freezing point of water.", true),
            new Question("Who is known as the father of modern physics?", "Albert Einstein", new string[] { "Isaac Newton", "Nikola Tesla" }, "Isaac Newton is known as the father of modern science.", false),
            new Question("What is the formula for force in physics?", "F = ma", new string[] { "F = mv", "F = m/v" }, "The formula for force is F = m/v.", false),
            new Question("Which element has the atomic number 1?", "Hydrogen", new string[] { "Helium", "Carbon" }, "Hydrogen is the element with the atomic number 1.", true),
            new Question("What is 10% of 500?", "50", new string[] { "25", "100" }, "10% of 500 is 25", false),
            new Question("Which programming language is primarily used for Android app development?", "Java", new string[] { "Python", "C++" }, "Android development primarily uses the programming language 'Java'.", true)
        };

        public QuestionDatabase(string filePath): base(filePath)
        {
            if(Instance != null)
            {
                throw new Exception("Singleton instance has already been created.");
            }
            Instance = this;
            Retrieve();
        }

        protected override void Retrieve()
        {
            Entries.Clear();
            using (StreamReader sr = new StreamReader(FilePath))
            {
                if(sr.BaseStream.Length == 0)
                {
                    Entries.AddRange(defaultQuestions);
                }
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] items = line.Split(',');

                    Entries.Add(new Question(items[0], items[1], new string[] { items[2], items[3] } , items[4], bool.Parse(items[5])));
                }
            }
            Write();
        }

        public override void Write()
        {
            using (StreamWriter sw = new StreamWriter(FilePath, false))
            {
                foreach(Question entry in Entries)
                {
                    string[] entryDetails = new string[] { entry.QuestionTerm, entry.CorrectAnswer, entry.FakeAnswers[0], entry.FakeAnswers[1], entry.TFQuestionTerm, entry.TFCorrectAnswer.ToString() };
                    sw.WriteLine(string.Join("," , entryDetails));
                }
            }
        }
    }
}
