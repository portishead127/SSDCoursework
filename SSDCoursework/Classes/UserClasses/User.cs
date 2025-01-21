using SSDCoursework.Forms.Misc;
using SSDCoursework.Forms.MainMenu;
using System;
using System.Windows.Forms;

namespace SSDCoursework.Classes.UserClasses
{
    internal abstract class User
    {
        static User currentUser;

        string fName;
        string sName;
        DateTime dob;
        int age;
        string username;
        string password;
        string email;
        bool isAdmin;


        public static User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string SName
        {
            get { return sName; }
            set { sName = value; }
        }

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
        }

        public bool IsAdmin
        {
            get { return isAdmin; }
        }

        public User(string fName, string sName, DateTime dob, string username, string email, string password, bool isAdmin)
        {
            this.fName = fName;
            this.sName = sName;
            this.dob = dob;
            this.username = username;
            this.email = email;
            this.password = password;
            this.isAdmin = isAdmin;
            age = CalculateAge();
        }

        int CalculateAge()
        {
            int yearDiff = dob.Year - DateTime.Today.Year;
            return yearDiff;
        }

        public void LoginUser()
        {
            currentUser = this;
            MessageBox.Show($"{fName}, you have successfully logged in as: {username}", "Logged in");
            (Application.OpenForms[0] as SplashScreen).Reset(0.05, new MainMenuHolder()); //Can guarantee that Application.OpenForms[0] will be a splashscreen as it starts the program with a splashscreen.
        }

        public abstract void DeleteUser(User userToDelete);
        public abstract void ChangePass(User userPassToChange, string newPass);
    }
}
