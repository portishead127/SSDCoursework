﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework
{
    public partial class SignUp : Form
    {
        User newUser;

        public SignUp()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                CreateUser();
            }
        }

        private void rdoAdmin_Click(object sender, EventArgs e)
        {
            rdoAdmin.Checked = !rdoAdmin.Checked;
        }

        private bool ValidateInput()
        {
            List<Exception> exceptions = new List<Exception>();

            foreach (Control c in tlp.Controls.OfType<TextBox>())
            {
                Label correspondingLabel = tlp.Controls.OfType<Label>().FirstOrDefault(label => label.Tag != null && label.Tag.Equals(c.Tag));

                if (c.Tag.Equals("Username"))
                {
                    exceptions = Validation.Validate(c.Text, 8, 20);
                }
                else if (c.Tag.Equals("Pass"))
                {
                    exceptions = Validation.Validate(c.Text, 8, 20, true);
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
                    correspondingLabel.ForeColor = Color.Red; // Change label text color to red
                    MessageBox.Show($"The {correspondingLabel.Text} entry contains the following issues:\n\n{errorMessage}", "Invalid credentials");
                }
                else if (correspondingLabel != null)
                {
                    correspondingLabel.ForeColor = Color.Black; // Reset label color if no errors
                }
            }

            if (exceptions.Any())
            {
                return false;
            }
            return true;
        }

        void CreateUser()
        {
            if (rdoAdmin.Checked)
            {
                newUser = new Admin(txtFirstName.Text, txtSurname.Text, datDOB.Value, txtUsername.Text, txtPassword.Text, true);
            }
            else
            {
                newUser = new Player(txtFirstName.Text, txtSurname.Text, datDOB.Value, txtUsername.Text, txtPassword.Text, false);
            }
            Database.AddUser(newUser);
            newUser.LoginUser();
        }
    }
}
