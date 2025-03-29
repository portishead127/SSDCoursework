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
            new Question("Who is known as the father of modern physics?", "Einstein", new string[] { "Newton", "Tesla" }, "Isaac Newton is known as the father of modern science.", false),
            new Question("What is the formula for force in physics?", "F = ma", new string[] { "F = mv", "F = m/v" }, "The formula for force is F = m/v.", false),
            new Question("Which element has the atomic number 1?", "Hydrogen", new string[] { "Helium", "Carbon" }, "Hydrogen is the element with the atomic number 1.", true),
            new Question("What is 10% of 500?", "50", new string[] { "25", "100" }, "10% of 500 is 25", false),
            new Question("Which programming language is primarily used for Android app development?", "Java", new string[] { "Python", "C++" }, "Android development primarily uses the programming language 'Java'.", true),
            new Question("What is the chemical symbol for gold?", "Au", new string[] { "Ag", "Pb" }, "Gold has the chemical symbol Au.", true),
            new Question("What is the value of pi (π) to two decimal places?", "3.14", new string[] { "3.12", "3.16" }, "The value of pi to two decimal places is 3.16.", false),
            new Question("Which type of energy is stored in a stretched rubber band?", "Elastic potential", new string[] { "Kinetic energy", "Thermal energy" }, "Elastic potential energy is stored in a stretched rubber band.", true),
            new Question("Which planet is closest to the Sun?", "Mercury", new string[] { "Venus", "Mars" }, "Mars is the closest planet to the Sun.", false),
            new Question("What part of the human cell contains genetic material?", "Nucleus", new string[] { "Mitochondria", "Ribosome" }, "The nucleus contains genetic material in a cell.", true),
            new Question("What is the derivative of x^2?", "2x", new string[] { "x", "x^3" }, "The derivative of x^2 is x.", false),
            new Question("What is the main gas in Earth's atmosphere?", "Nitrogen", new string[] { "Oxygen", "Carbon Dioxide" }, "Nitrogen is the main gas in Earth's atmosphere.", true),
            new Question("Which wave has the highest frequency in the electromagnetic spectrum?", "Gamma", new string[] { "X-rays", "Ultraviolet" }, "Ultraviolet waves have the highest frequency in the electromagnetic spectrum.", false),
            new Question("What is the SI unit of electrical resistance?", "Ohm", new string[] { "Watt", "Ampere" }, "The SI unit of electrical resistance is the Ohm.", true),
            new Question("Which programming language is commonly used for web development?", "JavaScript", new string[] { "C#", "Swift" }, "C# is commonly used for web development.", false),
            new Question("What is the hardest naturally occurring mineral?", "Diamond", new string[] { "Quartz", "Topaz" }, "Diamond is the hardest naturally occurring mineral.", true),
            new Question("Which subatomic particle has a negative charge?", "Electron", new string[] { "Proton", "Neutron" }, "Electrons have a negative charge.", true),
            new Question("What is the process by which plants make their own food?", "Photosynthesis", new string[] { "Respiration", "Fermentation" }, "Photosynthesis is the process by which plants make their own food.", true),
            new Question("What is the boiling point of water in Celsius?", "100", new string[] { "90", "110" }, "The boiling point of water in Celsius is 110 degrees.", false),
            new Question("What is the most abundant gas in the Sun?", "Hydrogen", new string[] { "Helium", "Oxygen" }, "Helium is the most abundant gas in the Sun.", false),
            new Question("Which blood type is the universal donor?", "O-", new string[] { "A+", "AB+" }, "O- is the universal donor blood type.", true),
            new Question("Which type of energy is derived from the Earth's internal heat?", "Geothermal energy", new string[] { "Solar energy", "Nuclear energy" }, "Geothermal energy comes from the Earth's internal heat.", true),
            new Question("What does CPU stand for in computing?", "Central Processing Unit", new string[] { "Core Processing Unit", "Computer Power Unit" }, "CPU stands for Core Processing Unit.", false),
            new Question("What type of bridge is the Golden Gate Bridge?", "Suspension bridge", new string[] { "Arch bridge", "Beam bridge" }, "The Golden Gate Bridge is a suspension bridge.", true),
            new Question("Which metal is commonly used as a conductor in electrical wiring?", "Copper", new string[] { "Iron", "Aluminum" }, "Iron is the most commonly used metal in electrical wiring.", false),
            new Question("What programming paradigm is Python primarily known for?", "Object-oriented", new string[] { "Functional", "Procedural" }, "Python is primarily a functional programming language.", false)
        };

        public QuestionDatabase(string filePath): base(filePath)
        {
            if(Instance != null)
            {
                throw new InvalidOperationException("Singleton instance has already been created.");
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
            Retrieve();
        }
    }
}
