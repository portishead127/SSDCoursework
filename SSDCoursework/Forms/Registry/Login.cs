using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.Misc.Colours;
using SSDCoursework.Classes.UserClasses;
using System;
using System.Windows.Forms;

namespace SSDCoursework.Forms.Registry
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            new DarkMode().ApplyColour(this);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            UserDatabase.FindUserToLogin(txtUsername.Text, txtPassword.Text);
        }
    }
}