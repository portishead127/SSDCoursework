using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework
{
    internal class Admin : User
    {
        private static int numOfAdmins;

        public Admin(string fName, string sName, DateTime dob, string username, string password, bool isAdmin) : base(fName, sName, dob, username, password, isAdmin) { }

        public static int NumOfAdmins
        {
            get { return numOfAdmins; }
            set { numOfAdmins = value; }
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
