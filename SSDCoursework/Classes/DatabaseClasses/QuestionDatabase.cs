using SSDCoursework.Classes.QuestionClasses;
using System;
using System.Collections.Generic;
using System.IO;


namespace SSDCoursework.Classes.DatabaseClasses
{
    internal class QuestionDatabase : Database<IQuestion>
    {
        QuestionDatabase instance;
        public QuestionDatabase Instance
        {
            get { return instance; }
        }

        static List<IQuestion> defaultQuestions = new List<IQuestion>()
        {
            // Multiple choice questions
new MultipleChoiceQuestion("What is the powerhouse of the cell?", "Mitochondria", "Nucleus", "Ribosome"),
new MultipleChoiceQuestion("Which gas do plants primarily take in during photosynthesis?", "Carbon dioxide", "Oxygen", "Nitrogen"),
new MultipleChoiceQuestion("What is the square root of 64?", "8", "6", "7"),
new MultipleChoiceQuestion("Which planet has the most moons?", "Saturn", "Jupiter", "Mars"),
new MultipleChoiceQuestion("What is the freezing point of water in Celsius?", "0", "100", "-10"),
new MultipleChoiceQuestion("Who is known as the father of modern physics?", "Albert Einstein", "Isaac Newton", "Nikola Tesla"),
new MultipleChoiceQuestion("What is the formula for force in physics?", "F = ma", "F = mv", "F = m/v"),
new MultipleChoiceQuestion("Which element has the atomic number 1?", "Hydrogen", "Helium", "Carbon"),
new MultipleChoiceQuestion("What is 10% of 500?", "50", "25", "100"),
new MultipleChoiceQuestion("Which programming language is primarily used for Android app development?", "Java", "Python", "C++"),

// True or false questions
new TrueOrFalseQuestion("The Earth revolves around the Sun.", true),
new TrueOrFalseQuestion("Sound travels faster in air than in water.", false),
new TrueOrFalseQuestion("Electric current is measured in amperes.", true),
new TrueOrFalseQuestion("The chemical formula for salt is NaCl.", true),
new TrueOrFalseQuestion("Humans share 90% of their DNA with bananas.", false),
new TrueOrFalseQuestion("Light is both a particle and a wave.", true),
new TrueOrFalseQuestion("The boiling point of water decreases at higher altitudes.", true),
new TrueOrFalseQuestion("Mars is the closest planet to the Sun.", false),
new TrueOrFalseQuestion("A byte is made up of 16 bits.", false),
new TrueOrFalseQuestion("The human brain has more neurons than stars in the Milky Way.", true),

// Written questions
new WrittenQuestion("What is the derivative of x^2 with respect to x?", "2x"),
new WrittenQuestion("Name the largest organ in the human body.", "Skin"),
new WrittenQuestion("What is the first element on the periodic table?", "Hydrogen"),
new WrittenQuestion("What is the binary representation of the decimal number 5?", "101"),
new WrittenQuestion("Name the process in which a liquid turns into a gas.", "Evaporation"),
new WrittenQuestion("What is the smallest prime number?", "2"),
new WrittenQuestion("Who proposed the theory of evolution by natural selection?", "Charles Darwin"),
new WrittenQuestion("What is the main gas found in the air we breathe?", "Nitrogen"),
new WrittenQuestion("What is the most abundant element in the universe?", "Hydrogen"),
new WrittenQuestion("What organ is responsible for pumping blood in the human body?", "Heart"),
new WrittenQuestion("What is the sum of the angles in a triangle?", "180"),
new WrittenQuestion("What is the basic building block of proteins?", "Amino acid"),
new WrittenQuestion("What is the process of splitting a nucleus to release energy called?", "Nuclear fission"),
new WrittenQuestion("Which planet is the largest in our solar system?", "Jupiter"),
        };

        public QuestionDatabase(string filePath): base(filePath)
        {
            if(instance != null)
            {
                throw new Exception("Singleton instance has already been created.");
            }
            instance = this;
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

                    switch (items[0])
                    {
                        case "TF":
                            Entries.Add(new TrueOrFalseQuestion(items[1], bool.Parse(items[2]))); break;
                        case "M":
                            Entries.Add(new MultipleChoiceQuestion(items[1], items[2], items[3], items[4])); break;
                        case "W":
                            Entries.Add(new WrittenQuestion(items[1], items[2])); break;
                        default: throw new Exception("Invalid question type");
                    }
                }
            }
            Write();
        }

        protected override void Write()
        {
            using (StreamWriter sw = new StreamWriter(FilePath, false))
            {
                foreach(IQuestion entry in Entries)
                {
                    string[] entryDetails;

                    switch(entry.GetType().Name){
                        case nameof(TrueOrFalseQuestion):
                            TrueOrFalseQuestion tfEntry = entry as TrueOrFalseQuestion;
                            entryDetails = new string[] { "TF", tfEntry.QuestionText, tfEntry.CorrectAnswer.ToString()};
                            break;
                        case nameof(MultipleChoiceQuestion):
                            MultipleChoiceQuestion mEntry = entry as MultipleChoiceQuestion;
                            entryDetails = new string[] { "M", mEntry.QuestionText, mEntry.CorrectAnswer, mEntry.FakeAnswer1, mEntry.FakeAnswer2};
                            break;
                        case nameof(WrittenQuestion):
                            WrittenQuestion wEntry = entry as WrittenQuestion;
                            entryDetails = new string[] { "W", wEntry.QuestionText, wEntry.CorrectAnswer };
                            break;
                        default: throw new Exception("Invalid question type.");
                    }
                    sw.WriteLine(string.Join("," , entryDetails));
                }
            }
        }
    }
}
