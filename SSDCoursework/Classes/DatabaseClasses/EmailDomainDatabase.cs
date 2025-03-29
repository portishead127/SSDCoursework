using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SSDCoursework.Classes.DatabaseClasses
{
    internal class EmailDomainDatabase : Database<string>
    {
        static string[] defaultDomains = new string[3] { "@gmail.com", "@outlook.com", "@yahoo.com" };

        public static EmailDomainDatabase Instance { get; set; }

        /// <summary>
        /// Creates a database object and sets the instance field equal to this instance. Throws an exception if the instance has already been set.
        /// </summary>
        /// <param name="filePath"></param>
        /// <exception cref="Exception"></exception>
        public EmailDomainDatabase(string filePath) : base(filePath)
        {
            if (Instance != null)
            {
                throw new InvalidOperationException("Singleton instance of this class has already been created.");
            }
            Instance = this;
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
        }

        public override void Write()
        {
            File.WriteAllText(FilePath, string.Join(",", Entries));
            Retrieve();
        }

        public new void RemoveEntry(string entry)
        {
            if (!defaultDomains.Contains(entry))
            {
                base.RemoveEntry(entry);
            }
            else
            {
                MessageBox.Show("Cannot remove a default email domain.");
            }
        }
    }
}