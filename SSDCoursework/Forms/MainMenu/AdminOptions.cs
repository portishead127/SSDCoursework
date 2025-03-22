using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.Misc;
using SSDCoursework.Classes.UserClasses;
using SSDCoursework.Classes.QuestionClasses;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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

            listBox1.DataSource = EmailDomainDatabase.Instance.Entries;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User userToChange = UserDatabase.FindUser(listBox2.SelectedValue.ToString());
            if (userToChange != null)
            {
                userToChange.ChangePass(userToChange, txtPassword.Text);
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

        private void btnRemoveQuestion_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvQuestions.Rows[dgvQuestions.CurrentRow.Index];
            dgvQuestions.Rows.Remove(row);
            
            UpdateBaseDatabase();
        }

        private void UpdateBaseDatabase()
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
            object[] textBoxEntries =
            {
                txtQuestionTerm.Text,
                txtWrittenAnswer.Text,
                txtFakeAnswer1.Text,
                txtFakeAnswer2.Text,
                txtTFQuestionTerm.Text,
                ckbTFAnswer.Checked
            };

            dt.Rows.Add(textBoxEntries);
            UpdateBaseDatabase();
        }

        private void ChangeUsername_Click(object sender, EventArgs e)
        {
            User userToChange = UserDatabase.FindUser(listBox2.SelectedItem.ToString());
            if (userToChange != null) {
                userToChange.ChangeUsername(userToChange, textBox2.Text);
            } 
            ReconstructUsers();
        }

        private void ReconstructUsers()
        {
            foreach (User temp in UserDatabase.Instance.Entries)
            {
                usernames.Add(temp.Username);
            }

            listBox2.DataSource = usernames;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserDatabase.Instance.RemoveEntry(UserDatabase.FindUser(listBox2.SelectedItem.ToString()));
            ReconstructUsers();
        }
    }
}
