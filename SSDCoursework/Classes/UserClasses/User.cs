using SSDCoursework.Forms.Misc;
using SSDCoursework.Forms.MainMenu;
using System;
using System.Windows.Forms;
using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.UserClasses.UserAttributes;

namespace SSDCoursework.Classes.UserClasses
{
    internal abstract class User
    {
        static User currentUser;

        public static User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        public DateTime Dob { get; set; }

        public string FName{ get; set; }

        public string SName { get; set; }

        public int Age { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public bool IsAdmin { get; }

        public Scorecard Scorecard { get; }

        public Settings Settings { get; }

        public User(string fName, string sName, DateTime dob, string username, string email, string password, bool isAdmin, Scorecard scorecard, Settings settings)
        {
            FName = fName;
            SName = sName;
            Dob = dob;
            Username = username;
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
            Scorecard = scorecard;
            Settings = settings;
            Age = CalculateAge();
        }

        int CalculateAge()
        {
            int yearDiff = Dob.Year - DateTime.Today.Year;
            return yearDiff;
        }

        public void LoginUser()
        {
            currentUser = this;
            MessageBox.Show($"{FName}, you have successfully logged in as: {Username}", "Logged in", MessageBoxButtons.OK, MessageBoxIcon.None);
            (Application.OpenForms[0] as SplashScreen).Reset(4, new MainMenuHolder()); //Can guarantee that Application.OpenForms[0] will be a splashscreen as it starts the program with a splashscreen.
        }

        public abstract void ChangeUsername(User userToChange, string newUsername);
        public abstract void DeleteUser(User userToDelete);
        public abstract void ChangePass(User userToChange, string newPass);
    }
}
