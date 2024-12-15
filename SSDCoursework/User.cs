﻿using System;
using System.Windows.Forms;

namespace SSDCoursework
{
    internal abstract class User
    {
        enum difficultyLevels
        {
            EASY,
            MEDIUM,
            HARD,
            MASTER
        }

        static User currentUser;

        string fName;
        string sName;
        DateTime dob;
        int age;
        string username;
        string password;
        string email;
        bool isAdmin;
        Enum difficultyLevel = difficultyLevels.EASY;


        public static User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        public Enum DifficultyLevel
        {
            get { return difficultyLevel; }
            set { difficultyLevel = value; }
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string SName
        {
            get { return sName; }
            set { sName = value; }
        }

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
        }

        public bool IsAdmin
        {
            get { return isAdmin; }
        }

        public User(string fName, string sName, DateTime dob, string username, string email, string password, bool isAdmin)
        {
            this.fName = fName;
            this.sName = sName;
            this.dob = dob;
            this.username = username;
            this.email = email;
            this.password = password;
            this.isAdmin = isAdmin;
            age = CalculateAge();

            currentUser = this;
        }

        int CalculateAge()
        {
            int yearDiff = dob.Year - DateTime.Today.Year;
            return yearDiff;
        }

        public void LoginUser()
        {
            MessageBox.Show($"{fName}, you have successfully logged in as: {username}", "Logged in");
            throw new NotImplementedException();
        }
        public abstract void DeleteUser(User userToDelete);
        public abstract void ChangePass(User userPassToChange);
    }
}
