using SSDCoursework.Forms.Misc;
using SSDCoursework.Forms.Registry;
using SSDCoursework.Classes.DatabaseClasses;
using System;
using System.IO;
using System.Windows.Forms;

namespace SSDCoursework.Classes.Misc
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            InitilizeFonts();
            InitilizeDatabases();

            // Your application code
            //Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(true);

            Application.Run(new SplashScreen(0.05, new RegistryHolder()));
        }

        static void InitilizeFonts()
        {
            ////Create your private font collection object.
            //PrivateFontCollection pfc = new PrivateFontCollection();

            ////Select your font from the resources.
            ////My font here is "Digireu.ttf"
            //int fontLength = Properties.Resources.Digireu.Length;

            //// create a buffer to read in to
            //byte[] fontdata = Properties.Resources.Digireu;

            //// create an unsafe memory block for the font data
            //System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            //// copy the bytes to the unsafe memory block
            //Marshal.Copy(fontdata, 0, data, fontLength);

            //// pass the font to the font collection
            //pfc.AddMemoryFont(data, fontLength);
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