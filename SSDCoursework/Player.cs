using System;

namespace SSDCoursework
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

        public override void ChangePass(User userPassToChange)
        {
            
            throw new NotImplementedException();
        }

        public override void DeleteUser(User userToDelete)
        {
            throw new NotImplementedException();
        }
    }
}
