using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.Misc;
using SSDCoursework.Classes.UserClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework.Forms.MainMenu
{
    public partial class AdminOptions : Form
    {
        public AdminOptions()
        {
            InitializeComponent();
            dgvQuestions.DataSource = QuestionDatabase.Instance.Entries;
            dgvQuestions.Columns.RemoveAt(dgvQuestions.Columns.Count - 1);
            listBox1.DataSource = EmailDomainDatabase.Instance.Entries;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User userToChange = UserDatabase.FindUser(txtUsername.Text);
            if (userToChange != null)
            {
                UserDatabase.Instance.RemoveEntry(userToChange);
                userToChange.Password = txtPassword.Text;
                UserDatabase.Instance.AddEntry(userToChange);
                MessageBox.Show("Updated user password.", "Password Changed", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("User could not be found.");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDomainToListbox(textBox1.Text);
            textBox1.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveDomainFromListbox();
            AddDomainToListbox(textBox1.Text);
            RedrawListbox();
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RemoveDomainFromListbox();
            RedrawListbox();
            textBox1.Text = "";
        }

        private void RedrawListbox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = EmailDomainDatabase.Instance.Entries;
        }

        private void AddDomainToListbox(string domain)
        {
            if (Validation.ValidateDomain(textBox1.Text).Count == 0)
            {
                EmailDomainDatabase.Instance.AddEntry(textBox1.Text);
                RedrawListbox();
            }
            else
            {
                MessageBox.Show("Desired domain must be valid.", "Invalid Domain");
            }
        }

        private void RemoveDomainFromListbox()
        {
            EmailDomainDatabase.Instance.RemoveEntry(EmailDomainDatabase.Instance.Entries[listBox1.SelectedIndex]);
        }
    }
}
