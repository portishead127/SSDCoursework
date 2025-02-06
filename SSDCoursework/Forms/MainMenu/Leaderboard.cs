using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.UserClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework.Forms.MainMenu
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
            Populate();
        }

        private void Populate()
        {
            label2.Text = User.CurrentUser.Username;
            label3.Text = User.CurrentUser.Scorecard.OverallScore.ToString();
            label4.Text = User.CurrentUser.Scorecard.TrueFalseHighScore.ToString();
            label5.Text = User.CurrentUser.Scorecard.MultipleChoiceHighScore.ToString();
            label6.Text = User.CurrentUser.Scorecard.WrittenHighScore.ToString();

            // For Add New Row (Loop this code for add multiple rows)
            foreach(User user in UserDatabase.Instance.Entries)
            {
                tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                tableLayoutPanel1.Controls.Add(new Label() { Text = user.Username }, 1, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = user.Scorecard.OverallScore.ToString()}, 2, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = user.Scorecard.TrueFalseHighScore.ToString()}, 3, tableLayoutPanel1.RowCount - 1);
            }

        }
    }
}
