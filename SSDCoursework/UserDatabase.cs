using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace SSDCoursework
{
    internal class UserDatabase : Database<User>
    {

        // Private constructor to prevent instantiation outside of the class
        private UserDatabase(string userFilePath) : base(userFilePath)
        {
            Retrieve();
        }

        // Static property to access the singleton instance of UserDatabase
        public static new UserDatabase Instance
        {
            get
            {
                return (UserDatabase)Database<User>.Instance;
            }
        }

        // Initialize the Singleton instance with the correct file path
        public static void Init(string userFilePath)
        {
            if (Database<User>.Instance == null)
            {
                // Create a new instance of UserDatabase and initialize the singleton
                Init(new UserDatabase(userFilePath));
            }
        }

        protected override void Retrieve()
        {
            Entries.Clear();
            string[] lines = File.ReadAllLines(FilePath);
            foreach (var line in lines)
            {
                string[] splitUserDetails = line.Split(',');
                User aUser;
                if (splitUserDetails[5] == "False")
                {
                    aUser = new Player(splitUserDetails[0], splitUserDetails[1], DateTime.Parse(splitUserDetails[2]), splitUserDetails[3], splitUserDetails[4], splitUserDetails[5], false);
                }
                else
                {
                    aUser = new Admin(splitUserDetails[0], splitUserDetails[1], DateTime.Parse(splitUserDetails[2]), splitUserDetails[3], splitUserDetails[4], splitUserDetails[5], true);
                }

                Entries.Add(aUser);
            }
        }

        protected override void Write()
        {
            using (StreamWriter sw = new StreamWriter(FilePath, false)) // Overwrite the file
            {
                foreach (User user in Entries)
                {
                    string[] userDataPoints =
                    {
                        user.FName, user.SName, user.Dob.ToString(), user.Username, user.Password, user.IsAdmin.ToString()
                    };
                    sw.WriteLine(string.Join(",", userDataPoints));
                }
            }
        }
    }
}
