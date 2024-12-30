using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework
{
    internal class EmailDomainDatabase : Database<string>
    {
        public EmailDomainDatabase(string emailDomainFilePath): base(emailDomainFilePath) { Retrieve();}

        public static new  EmailDomainDatabase Instance
        {
            get { return (EmailDomainDatabase)Database<string>.Instance;}
        } 

        /// <summary>
        /// Initialize the Singleton instance with the correct file path.
        /// </summary>
        /// <param name="emailDomainFilePath"></param>
        public static void Init(string emailDomainFilePath)
        {
            Init(new EmailDomainDatabase(emailDomainFilePath)); //Calls the base class's Init(Database<T>) function.
        }

        /// <summary>
        /// Replaces the entries list with the contents of the CSV and rewrites it to the CSV to sync it. If the CSV is empty, defaults to a few preset email domains.
        /// </summary>
        protected override void Retrieve()
        {
            Entries.Clear();
            string rawDomains = File.ReadAllText(FilePath);
            string[] domains;
            if (rawDomains == "")
            {
                domains = new string[] { "@gmail.com", "@c2ken.net", "@outlook.com", "@yahoo.com" };
            }
            else
            {
                domains = rawDomains.Split(',');
            }
            Entries.AddRange(domains);
            Write();
        }

        /// <summary>
        /// Overwrites the contents of the CSV with the contents of the entries list.
        /// </summary>
        protected override void Write()
        {
            using (StreamWriter sw = new StreamWriter(FilePath, false)) // Overwrite the file
            {
                foreach (string emailDomain in Entries)
                {
                    sw.WriteLine(string.Join(",", emailDomain));
                }
            }
        }
    }
}
