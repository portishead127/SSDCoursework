using System;
using System.IO;
using System.Windows.Forms;

namespace SSDCoursework
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            InitilizeDatabases();

            // Your application code
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Registry());
        }

        static void InitilizeDatabases()
        {
            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Databases"));
            
            EmailDomainDatabase.Init(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Databases", "EmailDomains.csv"));
            UserDatabase.Init(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Databases", "Users.csv"));

            //Passes the an instance of each database with the path from each individual Init() method to the base Init() method so that it can initialise the instance property with that object
            //This only happens if there is not already a value for instance
        }
    }
}
