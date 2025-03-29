using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.Misc;
using SSDCoursework.Classes.UserClasses;
using SSDCoursework.Classes.QuestionClasses;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;

namespace SSDCoursework.Forms.MainMenu
{
    internal partial class AdminOptions : Form
    {
        DataTable dt;
        List<string> usernames;
        public AdminOptions()
        {
            InitializeComponent();
            User.CurrentUser.Settings.ColourPalette.ApplyColour(this.Controls, this);
            dt = new DataTable();
            usernames = new List<string>();

            ReconstructUsers();


            dt.Columns.Add("Term", typeof(string));
            dt.Columns.Add("WrittenAnswer", typeof(string));
            dt.Columns.Add("FakeAnswer1", typeof(string));
            dt.Columns.Add("FakeAnswer2", typeof(string));
            dt.Columns.Add("TFQuestionTerm", typeof(string));
            dt.Columns.Add("TFAnswer", typeof(bool));

            foreach (Question question in QuestionDatabase.Instance.Entries)
            {
                dt.Rows.Add(new object[]
                {
                    question.QuestionTerm,
                    question.CorrectAnswer,
                    question.FakeAnswers[0],
                    question.FakeAnswers[1],
                    question.TFQuestionTerm,
                    question.TFCorrectAnswer
                }
                );
            }
            dgvQuestions.DataSource = dt;

            lstDomains.DataSource = EmailDomainDatabase.Instance.Entries;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                User userToChange = UserDatabase.FindUser(lstUsers.SelectedValue.ToString());
                if (userToChange != null)
                {
                    userToChange.ChangePass(userToChange, txtPassword.Text);
                }
            }
            catch { }
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
            AddDomainToListbox(txtDomain.Text);
            txtDomain.Text = "";
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
            RemoveDomainFromDatabase();
            AddDomainToListbox(txtDomain.Text);
            RedrawListbox();
            txtDomain.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RemoveDomainFromDatabase();
            RedrawListbox();
            txtDomain.Text = "";
        }

        private void RedrawListbox()
        {
            lstDomains.DataSource = null;
            lstDomains.DataSource = EmailDomainDatabase.Instance.Entries;
        }

        private void AddDomainToListbox(string domain)
        {
            if (Validation.ValidateDomain(domain).Any() || EmailDomainDatabase.Instance.Entries.Contains(domain))
            {
                MessageBox.Show("Desired domain must be valid and not a duplicate.", "Invalid Domain");
            }
            else
            {
                EmailDomainDatabase.Instance.AddEntry(domain);
                RedrawListbox();
            }
        }

        private void RemoveDomainFromDatabase()
        {
            EmailDomainDatabase.Instance.RemoveEntry(EmailDomainDatabase.Instance.Entries[lstDomains.SelectedIndex]);
        }

        private void btnRemoveQuestion_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvQuestions.Rows[dgvQuestions.CurrentRow.Index];
            dgvQuestions.Rows.Remove(row);
            
            UpdateQuestionDatabase();
        }

        private void UpdateQuestionDatabase()
        {
            QuestionDatabase.Instance.Entries.Clear();

            if(dt.Rows.Count == 0)
            {
                QuestionDatabase.Instance.Write();
                return;
            }
            foreach (DataRow dr in dt.Rows)
            {
                QuestionDatabase.Instance.AddEntry(
                    new Question(
                    dr.Field<string>(0),
                    dr.Field<string>(1),
                    new string[] { dr.Field<string>(2), dr.Field<string>(3) },
                    dr.Field<string>(4),
                    dr.Field<bool>(5)
                    )
                );    
            };
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            List<Exception> exceptions = new List<Exception>();

            object[] textBoxEntries =
            {
                txtQuestionTerm.Text,
                txtWrittenAnswer.Text,
                txtFakeAnswer1.Text,
                txtFakeAnswer2.Text,
                txtTFQuestionTerm.Text,
                ckbTFAnswer.Checked
            };
            for(int i = 0; i < textBoxEntries.Length-1; i++)
            {
                exceptions.AddRange(Validation.Validate(textBoxEntries[i].ToString().Trim()));
            }

            if (!exceptions.Any())
            {
                dt.Rows.Add(textBoxEntries);
                UpdateQuestionDatabase();
            }
            else
            {
                MessageBox.Show("Inputs cannot be empty.", "Invalid Question");
            }
            
        }

        private void ChangeUsername_Click(object sender, EventArgs e)
        {
            try
            {
                User userToChange = UserDatabase.FindUser(lstUsers.SelectedItem.ToString());
                if (userToChange != null)
                {
                    User.CurrentUser.ChangeUsername(userToChange, textBox2.Text);
                }
                ReconstructUsers();
            }
            catch { }
        }

        private void ReconstructUsers()
        {
            lstUsers.DataSource = null;

            usernames.Clear();
            foreach (User temp in UserDatabase.Instance.Entries)
            {
                usernames.Add(temp.Username);
            }

            lstUsers.DataSource = usernames;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                User userToChange = UserDatabase.FindUser(lstUsers.SelectedItem.ToString());
                User.CurrentUser.DeleteUser(userToChange);
                ReconstructUsers();
            }
            catch { };
        }
    }
}
