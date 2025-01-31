using SSDCoursework.Classes.QuestionClasses;
using SSDCoursework.Classes.UserClasses;
using System;
using System.IO;
using System.Windows.Forms;

namespace SSDCoursework.Classes.DatabaseClasses
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
            using(StreamReader sr = new StreamReader(FilePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] items = line.Split(',');
                    if (items[5] == bool.FalseString)
                    {
                        Entries.Add(new Player(items[0], items[1], DateTime.Parse(items[2]), items[3], items[4], items[5], false));
                    }
                    else
                    {
                        Entries.Add(new Admin(items[0], items[1], DateTime.Parse(items[2]), items[3], items[4], items[5], true));
                    }
                }
            }
        }

        public override void Write()
        {
            using (StreamWriter sw = new StreamWriter(FilePath, true)) // Overwrite the file.
            {
                foreach (User user in Entries)
                {
                    string[] userDataPoints =
                    {
                        user.FName, user.SName, user.Dob.ToString(), user.Username, user.Email, user.Password, user.IsAdmin.ToString()
                    };
                    sw.WriteLine(string.Join(",", userDataPoints));
                }
            }
        }

        public static void FindUserToLogin(string desiredUsername, string desiredPass)
        {
            User userFound = null;

            foreach (User tempUser in Instance.Entries)
            {
                if (tempUser.Username == desiredUsername)
                {
                    if (tempUser.Password == desiredPass)
                    {
                        userFound = tempUser; break;
                    }
                }
            }

            if (userFound == null)
            {
                MessageBox.Show("User could not be found.", "Invalid credentials");
                return;
            }
            userFound.LoginUser();
        }

        public static User FindUser(string username)
        {
            foreach (User tempUser in Instance.Entries)
            {
                if (tempUser.Username == username)
                {
                    return tempUser;
                }
            }
            return null;
        }
    }
}
