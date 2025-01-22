using System;
using System.IO;
using System.Linq;

namespace SSDCoursework.Classes.DatabaseClasses
{
    internal class EmailDomainDatabase : Database<string>
    {
        static string[] defaultDomains = new string[3] { "@gmail.com", "@outlook.com", "@yahoo.com" };

        private static EmailDomainDatabase instance;
        public static EmailDomainDatabase Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Creates a database object and sets the instance field equal to this instance. Throws an exception if the instance has already been set.
        /// </summary>
        /// <param name="filePath"></param>
        /// <exception cref="Exception"></exception>
        public EmailDomainDatabase(string filePath) : base(filePath)
        {
            if (instance != null)
            {
                throw new Exception("Singleton instance of this class has already been created.");
            }
            instance = this;
            Retrieve();
        }

        protected override void Retrieve()
        {
            Entries.Clear();
            string rawDomains = File.ReadAllText(FilePath);
            if (!rawDomains.Contains(defaultDomains[0]) || !rawDomains.Contains(defaultDomains[1]) || !rawDomains.Contains(defaultDomains[2]))
            {
                Entries.AddRange(defaultDomains);
            }
            else
            {
                Entries.AddRange(rawDomains.Split(','));
            }
            Write();
        }

        protected override void Write()
        {
            File.WriteAllText(FilePath, string.Join(",", Entries));
        }

        public new void RemoveEntry(string entry)
        {
            if (!defaultDomains.Contains(entry))
            {
                Entries.Remove(entry);
                Write();
            }
        }
    }
}