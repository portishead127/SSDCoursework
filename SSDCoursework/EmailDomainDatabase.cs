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
        public EmailDomainDatabase(string emailDomainFilePath): base(emailDomainFilePath)
        {
            Retrieve();
        }

        public static new  EmailDomainDatabase Instance
        {
            get
            {
                return (EmailDomainDatabase)Database<string>.Instance;
            }
        } 

        // Initialize the Singleton instance with the correct file path
        public static void Init(string emailDomainFilePath)
        {
            if (Database<string>.Instance == null)
            {
                Init(new EmailDomainDatabase(emailDomainFilePath));
            }
        }

        protected override void Retrieve()
        {
            Entries.Clear();
            string rawDomains = File.ReadAllText(FilePath);
            string[] domains;
            if (rawDomains == "")
            {
                domains = new string[] { "@gmail.com", "@c2ken.net", "@outlook.com", "@yahoo.com", "@hotmail.com" };
            }
            else
            {
                domains = rawDomains.Split(',');
            }
            Entries.AddRange(domains);
        }

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
