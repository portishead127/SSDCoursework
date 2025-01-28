using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.Misc;
using SSDCoursework.Classes.UserClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSDCoursework.Forms.Registry
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            FindUser();
        }

        private void FindUser()
        {
            User userFound = null;

            foreach (User tempUser in UserDatabase.Instance.Entries)
            {
                if (tempUser.Username == txtUsername.Text)
                {
                    if (tempUser.Password == txtPassword.Text)
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
    }
}