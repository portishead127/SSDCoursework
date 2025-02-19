using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.Misc;
using SSDCoursework.Classes.UserClasses;
using SSDCoursework.Classes.UserClasses.UserAttributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSDCoursework.Forms.Registry
{
    public partial class SignUp : Form
    {
        User newUser;

        public SignUp()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                CreateUser();
            }
        }

        private void RdoAdmin_Click(object sender, EventArgs e)
        {
            rdoAdmin.Checked = !rdoAdmin.Checked;
        }

        private bool ValidateInput()
        {
            List<Exception> exceptions = new List<Exception>();
            bool valid = true;
            foreach (Control c in Controls.OfType<TextBox>())
            {
                Label correspondingLabel = Controls.OfType<Label>().FirstOrDefault(label => label.Tag != null && label.Tag.Equals(c.Tag));

                if (c.Tag.Equals("Username"))
                {
                    exceptions = Validation.ValidateUsername(c.Text);
                }
                else if (c.Tag.Equals("Pass"))
                {
                    exceptions = Validation.ValidatePass(c.Text);
                }
                else if(c.Tag.Equals("Email"))
                {
                    exceptions = Validation.ValidateEmail(c.Text);
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

        void CreateUser()
        {
            if (rdoAdmin.Checked)
            {
                newUser = new Admin(txtFirstName.Text, txtSurname.Text, datDOB.Value, txtUsername.Text, txtEmail.Text, txtPassword.Text, true, new Scorecard(), new Settings());
            }
            else
            {
                newUser = new Player(txtFirstName.Text, txtSurname.Text, datDOB.Value, txtUsername.Text, txtEmail.Text, txtPassword.Text, false, new Scorecard(), new Settings());
            }
            UserDatabase.Instance.AddEntry(newUser);
            newUser.LoginUser();
        }
    }
}
