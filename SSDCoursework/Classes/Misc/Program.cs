using SSDCoursework.Forms.Misc;
using SSDCoursework.Forms.Registry;
using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Forms.MainMenu;
using System;
using System.IO;
using System.Windows.Forms;
using SSDCoursework.Classes.QuestionClasses;
using SSDCoursework.Forms.MainMenu.QuizMenu;
using SSDCoursework.Forms.MainMenu.Arcade;

//SCREEN BOUNDARIES ARE 1386 x 768

namespace SSDCoursework.Classes.Misc
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            InitilizeDatabases();

            // Your application code
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new SplashScreen(3, new RegistryHolder()));
        }

        static void InitilizeDatabases()
        {
            string DatabasesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Databases");

            Directory.CreateDirectory(DatabasesPath);
            new EmailDomainDatabase(Path.Combine(DatabasesPath, "EmailDomains.csv"));
            new UserDatabase(Path.Combine(DatabasesPath, "Users.csv"));
            new QuestionDatabase(Path.Combine(DatabasesPath, "Questions.csv"));
        }
    }
}