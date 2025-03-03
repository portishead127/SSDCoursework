using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.UserClasses.UserAttributes;
using System;

namespace SSDCoursework.Classes.UserClasses
{
    internal class Player : User
    {
        static int numOfPlayers;

        public Player(string fName, string sName, DateTime dob, string username, string email, string password, bool isAdmin, Scorecard scorecard, Settings settings) : base(fName, sName, dob, username, email, password, isAdmin, scorecard, settings) { }
        
        public int NumOfPlayers
        {
            get { return numOfPlayers; }
            set { numOfPlayers = value; }
        }

        public override void ChangeUsername(User userToChange, string newUsername)
        {
            if(userToChange == this)
            {
                Username = newUsername;
            }
            else
            {
                throw new InvalidOperationException("Players cannot change the username of other users.");
            }
        }

        public override void ChangePass(User userToChange, string newPass)
        {
            if (userToChange == this)
            {
                Password = newPass;
            }
            else
            {
                throw new InvalidOperationException("Players cannot change the password of other users.");
            }
        }

        public override void DeleteUser(User userToDelete)
        {
            if(userToDelete == this)
            {
                UserDatabase.Instance.Entries.Remove(this);
            }
            else
            {
                throw new InvalidOperationException("Players cannot delete other users.");
            }
        }
    }
}
