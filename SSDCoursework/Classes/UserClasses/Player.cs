using SSDCoursework.Classes.DatabaseClasses;
using System;

namespace SSDCoursework.Classes.UserClasses
{
    internal class Player : User
    {
        static int numOfPlayers;

        public Player(string fName, string sName, DateTime dob, string username, string email, string password, bool isAdmin) : base(fName, sName, dob, username, email, password, isAdmin) { }
        
        public int NumOfPlayers
        {
            get { return numOfPlayers; }
            set { numOfPlayers = value; }
        }

        public override void ChangePass(User userPassToChange, string newPass)
        {
            if (userPassToChange == this)
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
