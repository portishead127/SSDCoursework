using Microsoft.Win32;
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
    internal class Player : User
    {
        static int numOfPlayers;

        public Player(string fName, string sName, DateTime dob, string gender, string username, string email, string password, bool isAdmin, Scorecard scorecard, Settings settings) : base(fName, sName, dob, gender, username, email, password, isAdmin, scorecard, settings) { }
        
        public int NumOfPlayers
        {
            get { return numOfPlayers; }
            set { numOfPlayers = value; }
        }

        public override void ChangeUsername(User userToChange, string newUsername)
        {
            if (Validation.ValidateUsername(newUsername).Any())
            {
                MessageBox.Show("Username is invalid. Please try again.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.Username == userToChange.Username)
                {
                    Username = newUsername;
                    UserDatabase.Instance.Write();
                    MessageBox.Show("Username changed successfully.", "Username Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new InvalidOperationException("Players cannot change the username of other users.");
                }
            }
        }

        public override void ChangePass(User userToChange, string newPass)
        {
            if(Validation.ValidatePass(newPass).Any())
            {
                MessageBox.Show("Password is invalid. Please try again.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (userToChange == this)
                {
                    Password = newPass;
                    UserDatabase.Instance.Write();
                    MessageBox.Show("Password changed successfully.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new InvalidOperationException("Players cannot change the password of other users.");
                }
            }   
        }

        public override void DeleteUser(User userToDelete)
        {
            if(this.Username == userToDelete.Username)
            {
                if (MessageBox.Show("Are you sure you want to delete your account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    UserDatabase.Instance.Entries.Remove(userToDelete);
                    UserDatabase.Instance.Write();
                    CurrentUser = null;
                    Application.OpenForms[0]?.Invoke(new Action(() =>
                    {
                        (Application.OpenForms[0] as SplashScreen)?.Reset(4, new RegistryHolder());
                    }));
                }
            }
            else
            {
                throw new InvalidOperationException("Players cannot delete other users.");
            }
        }
    }
}
