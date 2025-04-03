using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.Misc;
using SSDCoursework.Classes.Misc.Colours;
using SSDCoursework.Classes.UserClasses;
using SSDCoursework.Classes.UserClasses.UserAttributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework.Forms.Registry
{
    /// <summary>
    /// See Sign Up Form section.
    /// </summary>
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            new DarkMode().ApplyColour(this.Controls, this);
            cmbGender.SelectedIndex = 0;
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

        /// <summary>
        /// Validates all input fields on the form. If any are invalid, the user is informed of the issues and the corresponding labels turn red.
        /// </summary>
        /// <returns></returns>
        private bool ValidateInput()
        {
            List<Exception> exceptions = new List<Exception>();
            bool valid = true;

            // Validate TextBoxes
            foreach (Control c in Controls.OfType<TextBox>())
            {
                Label correspondingLabel = Controls.OfType<Label>().FirstOrDefault(label => label.Tag != null && label.Tag.ToString().Contains(c.Tag.ToString()));

                if (c.Tag.ToString().Contains("Username"))
                {
                    exceptions = Validation.ValidateUsername(c.Text.Trim());
                }
                else if (c.Tag.ToString().Contains("Pass"))
                {
                    exceptions = Validation.ValidatePass(c.Text.Trim());
                }
                else if (c.Tag.ToString().Contains("Email"))
                {
                    exceptions = Validation.ValidateEmail(c.Text.Trim());
                }
                else
                {
                    exceptions = Validation.Validate(c.Text.Trim());
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
                    correspondingLabel.ForeColor = Color.Red;
                    MessageBox.Show($"The {correspondingLabel.Text} entry contains the following issues:\n\n{errorMessage}", "Invalid credentials");
                }
                else if (correspondingLabel != null)
                {
                    correspondingLabel.ForeColor = new DarkMode().PaletteHash["ButtonTextColour"];
                }
            }
            return valid;
        }

        void CreateUser()
        {
            if (rdoAdmin.Checked)
            {
                UserDatabase.Instance.AddEntry(new Admin(txtFirstName.Text, txtSurname.Text, datDOB.Value, cmbGender.SelectedItem.ToString(), txtUsername.Text, txtEmail.Text, txtPassword.Text, true, new Scorecard(), new Settings()));

            }
            else
            {
                UserDatabase.Instance.AddEntry(new Player(txtFirstName.Text, txtSurname.Text, datDOB.Value, cmbGender.SelectedItem.ToString(), txtUsername.Text, txtEmail.Text, txtPassword.Text, false, new Scorecard(), new Settings()));
            }
            UserDatabase.FindUserToLogin(txtUsername.Text, txtPassword.Text);
        }

        private void btnPasswordVis_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}