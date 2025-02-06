using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.UserClasses.UserAttributes;
using System;

namespace SSDCoursework.Classes.UserClasses
{
    internal class Admin : User
    {
        private static int numOfAdmins;

        public Admin(string fName, string sName, DateTime dob, string username, string email, string password, bool isAdmin, Scorecard scorecard, Settings settings) : base(fName, sName, dob, username, email, password, isAdmin, scorecard, settings) { }

        public static int NumOfAdmins
        {
            get { return numOfAdmins; }
            set { numOfAdmins = value; }
        }

        public override void ChangeUsername(User userToChange, string newUsername)
        {
            userToChange.Username = newUsername;
        }

        public override void ChangePass(User userToChange, string newPass)
        {
            userToChange.Password = newPass;
        }

        public override void DeleteUser(User userToDelete)
        {
            UserDatabase.Instance.Entries.Remove(userToDelete);
        }
    }
}
