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
        static int numOfUsers = File.ReadAllLines(filePath).Length;
        static int numOfDataPoints = 6;
        const string filePath = "Users.csv";//const and static
        static List<User> users;

        public static int NumOfUsers
        {
            get { return numOfUsers; }
            set { numOfUsers = value;}
        }

        public static string FilePath
        {
            get { return filePath; }
        }

        public static void RetrieveCSV()
        {
            string[] splitUserDetails;
            User aUser;

            users.Clear();
            for (int i = 0; i < numOfUsers; i++)
            {
                splitUserDetails = File.ReadAllLines(filePath)[i].Split(',');
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
            WriteToCSV();
            RetrieveCSV();
        }


        public static void WriteToCSV()
        {
            StreamWriter sw = new StreamWriter(filePath, true);

            File.WriteAllText(filePath, ""); //Clears file
            string[] currentUserDataPoints = new string[numOfDataPoints];
            User currentUserBeingAddedToCSV;
            for(int i = 0; i < numOfUsers; i++)
            {
                currentUserBeingAddedToCSV = users[i];
                currentUserDataPoints[0] = currentUserBeingAddedToCSV.FName;
                currentUserDataPoints[1] = currentUserBeingAddedToCSV.SName;
                currentUserDataPoints[2] = currentUserBeingAddedToCSV.Dob.ToString();
                currentUserDataPoints[3] = currentUserBeingAddedToCSV.Username;
                currentUserDataPoints[4] = currentUserBeingAddedToCSV.Password;
                currentUserDataPoints[5] = currentUserBeingAddedToCSV.IsAdmin.ToString();
                
                for(int j = 0; j < numOfDataPoints; j++)
                {
                    sw.Write(currentUserDataPoints[j] + ',');
                }
            }
        }
    }
}
