using SSDCoursework.Classes.DatabaseClasses;
using System;
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
            UserDatabase.FindUserToLogin(txtUsername.Text, txtPassword.Text);
        }
    }
}