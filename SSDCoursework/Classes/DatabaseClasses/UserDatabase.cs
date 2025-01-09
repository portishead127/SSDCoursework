using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace SSDCoursework
{
    internal class UserDatabase : Database<User>
    {
        private static UserDatabase instance;
        public static UserDatabase Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Creates a database object and sets the instance field equal to this instance. Throws an exception if the instance has already been set.
        /// </summary>
        /// <param name="filePath"></param>
        /// <exception cref="Exception"></exception>
        public UserDatabase(string filePath) : base(filePath)
        {
            if (instance != null)
            {
                throw new Exception("Singleton instance of this class has already been created.");
            }
            instance = this;
            Retrieve();
        }

        protected override void Retrieve()
        {
            Entries.Clear();
            string[] lines = File.ReadAllLines(FilePath);
            foreach (string line in lines)
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
            using (StreamWriter sw = new StreamWriter(FilePath, false)) // Overwrite the file.
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
