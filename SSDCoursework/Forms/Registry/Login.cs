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

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                FindUser();
            }
        }

        private bool ValidateInput()
        {
            List<Exception> exceptions = new List<Exception>();
            bool valid = true;

            foreach (Control c in tlp.Controls.OfType<TextBox>())
            {
                Label correspondingLabel = tlp.Controls.OfType<Label>().FirstOrDefault(label => label.Tag != null && label.Tag.Equals(c.Tag));

                if (c.Tag.Equals("Username"))
                {
                    exceptions = Validation.Validate(c.Text, 8, 20);
                }
                else if (c.Tag.Equals("Pass"))
                {
                    exceptions = Validation.ValidatePass(c.Text, 8, 20);
                }
                else
                {
                    exceptions = Validation.Validate(c.Text);
                }

                //Constructing the error message
                StringBuilder errorMessage = new StringBuilder();
                foreach (Exception ex in exceptions)
                {
                    errorMessage.AppendLine(ex.Message);
                }

                // Change label color if there are exceptions
                if (exceptions.Any() && correspondingLabel != null)
                {
                    valid = false;
                    correspondingLabel.ForeColor = Color.Red; // Change label text color to red
                    MessageBox.Show($"The {correspondingLabel.Text} entry contains the following issues:\n\n{errorMessage}", "Invalid credentials");
                }
                else if (correspondingLabel != null)
                {
                    correspondingLabel.ForeColor = Color.White; // Reset label color if no errors
                }
            }
            return valid;
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