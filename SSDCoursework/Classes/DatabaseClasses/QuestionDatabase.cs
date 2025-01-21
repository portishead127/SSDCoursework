using SSDCoursework.Classes.QuestionClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace SSDCoursework.Classes.DatabaseClasses
{
    internal class QuestionDatabase : Database<Question<object>>
    {
        //[Question type], [Question term], [Answer], [Mult: FakeAnswer1], [Mult: FakeAnswer2]

        private static readonly List<Question<object>> defaultQuestions = new List<Question<object>>
        {
        };

        private static QuestionDatabase instance;
        public static QuestionDatabase Instance
        {
            get { return instance; }
        }

        public QuestionDatabase(string filepath) : base(filepath)
        {
            if(instance != null)
            {
                throw new Exception("Singleton instance of this class has already been created.");
            }
            instance = this;
            Retrieve();
        }
        
        protected override void Retrieve()
        {
            Entries.Clear();
            string[] lines = File.ReadAllLines(FilePath);
            foreach (string line in lines)
            {
                if (String.IsNullOrEmpty(line))
                {
                    Entries.AddRange(defaultQuestions);
                }
            }
        }

        protected override void Write()
        {
            throw new NotImplementedException();
        }
    }
}
