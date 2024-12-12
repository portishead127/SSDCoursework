using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SSDCoursework
{
    internal static class Database
    {
        static int numOfUsers = File.ReadAllLines(path).Length;
        static int numOfDataPoints = 6;
        const string path = "Users.csv";//const and static
        static List<User> users;

        public static int NumOfUsers
        {
            get { return numOfUsers; }
            set { numOfUsers = value;}
        }

        public static void RetrieveCSV()
        {
            string[] splitUserDetails;
            User aUser;

            for (int i = 0; i < numOfUsers; i++)
            {
                splitUserDetails = File.ReadAllLines(path)[i].Split(',');
                if (splitUserDetails[5] == "False")
                {
                    aUser = new Player(splitUserDetails[0], splitUserDetails[1], DateTime.Parse(splitUserDetails[2]), splitUserDetails[3], splitUserDetails[4], Convert.ToBoolean(splitUserDetails[5]));
                }
                else
                {
                    aUser = new Admin(splitUserDetails[0], splitUserDetails[1], DateTime.Parse(splitUserDetails[2]), splitUserDetails[3], splitUserDetails[4], Convert.ToBoolean(splitUserDetails[5]));
                }
                users.Add(aUser);
            }
        }

        public static void AddUser(User userToAdd)
        {
            users.Add(userToAdd);
        }


        public static void WriteToCSV()
        {
            File.WriteAllText(path, ""); //Clears file
            string[] currentLineToWrite = new string[numOfDataPoints];
            User currentUser;
            for(int i = 0; i < numOfUsers; i++)
            {
                currentUser = users[i];
                currentLineToWrite[0] = currentUser.FName;
                currentLineToWrite[1] = currentUser.SName;
                currentLineToWrite[2] = currentUser.Dob.ToString();
                currentLineToWrite[3] = currentUser.Username;
                currentLineToWrite[4] = currentUser.Password;
                currentLineToWrite[5] = currentUser.IsAdmin.ToString();

                for(int j = 0; j < numOfDataPoints; j++)
                {
                    
                }
            }
        }
    }
}
