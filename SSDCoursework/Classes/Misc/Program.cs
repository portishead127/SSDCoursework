using SSDCoursework.Forms;
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
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new SplashScreen());
        }

        static void InitilizeDatabases()
        {
            string DatabasesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Databases");
            Directory.CreateDirectory(DatabasesPath);

            new EmailDomainDatabase(Path.Combine(DatabasesPath, "EmailDomains.csv"));
            new UserDatabase(Path.Combine(DatabasesPath, "Users.csv"));
        }
    }
}
