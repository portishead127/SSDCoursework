using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.Misc;
using SSDCoursework.Classes.UserClasses.UserAttributes;
using SSDCoursework.Forms.Misc;
using SSDCoursework.Forms.Registry;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SSDCoursework.Classes.UserClasses
{
    internal class Admin : User
    {
        private static int numOfAdmins;

        public Admin(string fName, string sName, DateTime dob, string gender, string username, string email, string password, bool isAdmin, Scorecard scorecard, Settings settings) : base(fName, sName, dob, gender, username, email, password, isAdmin, scorecard, settings) { }

        public static int NumOfAdmins
        {
            get { return numOfAdmins; }
            set { numOfAdmins = value; }
        }

        public override void ChangeUsername(User userToChange, string newUsername)
        {
            if (Validation.ValidateUsername(newUsername).Any())
            {
                MessageBox.Show("The new username is invalid. Please try again.", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                userToChange.Username = newUsername;
                MessageBox.Show("Username changed successfully.", "Username changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserDatabase.Instance.Write();
            }
        }

        public override void ChangePass(User userToChange, string newPass)
        {
            if(Validation.ValidatePass(newPass).Any())
            {
                MessageBox.Show("The new password is invalid. Please try again.", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                userToChange.Password = newPass;
                MessageBox.Show("Password changed successfully.", "Password changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserDatabase.Instance.Write();
            }
        }

        public override void DeleteUser(User userToDelete)
        {
            if (userToDelete == this)
            {
                if (MessageBox.Show("Are you sure you want to delete your account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    UserDatabase.Instance.Entries.Remove(this);
                    CurrentUser = null;
                    (Application.OpenForms[0] as SplashScreen).Reset(4, new RegistryHolder());
                }
            }
            else
            {
                UserDatabase.Instance.Entries.Remove(userToDelete);
            }
            UserDatabase.Instance.Write();
        }
    }
}
