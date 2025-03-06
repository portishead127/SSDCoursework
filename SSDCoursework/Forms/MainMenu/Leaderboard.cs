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
            UserDatabase.Instance.Entries = UserDatabase.Instance.Entries.OrderByDescending(x => x.Scorecard.OverallScore).ToList();
            InitializeComponent();
            Populate();
            User.CurrentUser.Settings.ColourPalette.ApplyColour(this.Controls, this);
        }

        private void Populate()
        {
            FontFamily fontFamilty = new FontFamily("Microsoft Sans Serif");
            Font font = new Font(fontFamilty, 15.25f, FontStyle.Regular);
            pictureBox1.Image = User.CurrentUser.Settings.PFP;
            label7.Text = User.CurrentUser.Username + " (You)";
            label8.Text = User.CurrentUser.Scorecard.OverallScore.ToString();
            label9.Text = User.CurrentUser.Scorecard.TrueFalseHighScore.ToString();
            label10.Text = User.CurrentUser.Scorecard.MultipleChoiceHighScore.ToString();
            label11.Text = User.CurrentUser.Scorecard.WrittenHighScore.ToString();

            // For Add New Row (Loop this code for add multiple rows)
            foreach(User user in UserDatabase.Instance.Entries)
            {
                if (user.Settings.IsShownOnLeaderboard)
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    tableLayoutPanel1.Controls.Add(new PictureBox() {Margin = Padding.Empty, Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom, Image = user.Settings.PFP, BackColor = Color.FromName("DimGray")}, 0, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = user.Username, TextAlign = ContentAlignment.MiddleRight, Dock = DockStyle.Fill, Font = font, BackColor = Color.FromName("DimGray") }, 1, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = user.Scorecard.OverallScore.ToString(), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill, Font = font, BackColor = Color.FromName("DimGray") }, 2, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = user.Scorecard.TrueFalseHighScore.ToString(), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill, Font = font , BackColor = Color.FromName("DimGray") }, 3, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = user.Scorecard.MultipleChoiceHighScore.ToString(), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill, Font = font , BackColor = Color.FromName("DimGray") }, 4, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = user.Scorecard.WrittenHighScore.ToString(), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill, Font = font , BackColor = Color.FromName("DimGray") }, 5, tableLayoutPanel1.RowCount - 1);
                }
            }
        }
    }
}
