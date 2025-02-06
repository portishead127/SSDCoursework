using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.UserClasses.UserAttributes;
using System;

namespace SSDCoursework.Classes.UserClasses
{
    internal class Admin : User
    {
        private static int numOfAdmins;

        public Admin(string fName, string sName, DateTime dob, string username, string email, string password, bool isAdmin, Scorecard scorecard) : base(fName, sName, dob, username, email, password, isAdmin, scorecard) { }

        public static int NumOfAdmins
        {
            get { return numOfAdmins; }
            set { numOfAdmins = value; }
        }

        public override void ChangePass(User userPassToChange, string newPass)
        {
            userPassToChange.Password = newPass;
        }

        public override void DeleteUser(User userToDelete)
        {
            UserDatabase.Instance.Entries.Remove(userToDelete);
        }
    }
}
