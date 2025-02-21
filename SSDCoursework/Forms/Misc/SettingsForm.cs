using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.Misc;
using SSDCoursework.Classes.Misc.Colours;
using SSDCoursework.Classes.UserClasses;
using SSDCoursework.Classes.UserClasses.UserAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework.Forms.Misc
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            if(User.CurrentUser.Settings.ColourPalette.GetType() == typeof(DarkMode))
            {
                rdoDarkMode.Checked = true;
            }
            else
            {
                rdoDarkMode.Checked = false;
            }

            rdoLeaderboard.Checked = User.CurrentUser.Settings.IsShownOnLeaderboard;

            if(User.CurrentUser.Settings.PFP != null)
            {
                pictureBox1.Image = User.CurrentUser.Settings.PFP;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.EmptyProfilePic;
            }

            User.CurrentUser.Settings.ColourPalette.ApplyColour(this);
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            User.CurrentUser.ChangePass(User.CurrentUser, textBox1.Text);
        }

        private void btnUsername_Click(object sender, EventArgs e)
        {
            User.CurrentUser.ChangeUsername(User.CurrentUser, textBox2.Text);
        }

        private void btnSelectPFP_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select an Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";                                                                     

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = opFile.SafeFileName;   
                    string filepath = opFile.FileName;
                    string destinationPath = Path.Combine(Settings.UserImagesDirectory, iName);

                    if (!File.Exists(destinationPath))
                    {
                        File.Copy(filepath, destinationPath);
                    }
                    else
                    {
                        // Optionally, overwrite the existing file
                        File.Copy(filepath, destinationPath, true);
                    }

                    Bitmap pfp = new Bitmap(opFile.OpenFile());

                    pictureBox1.Image = pfp;
                    User.CurrentUser.Settings.AddPFP(pfp, destinationPath);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        private void btnRemovePFP_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            User.CurrentUser.Settings.RemovePFP();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            User.CurrentUser.DeleteUser(User.CurrentUser);
        }

        private void rdoDarkMode_Click(object sender, EventArgs e)
        {
            rdoDarkMode.Checked = !rdoDarkMode.Checked;

            if (rdoDarkMode.Checked)
            {
                User.CurrentUser.Settings.ColourPalette = new DarkMode();
            }
            else
            {
                User.CurrentUser.Settings.ColourPalette = new LightMode();
            }

            // Apply updated colors
            User.CurrentUser.Settings.ColourPalette.ApplyColour(this);

            // Force UI refresh
            this.Invalidate();
            this.Refresh();

            UserDatabase.Instance.Write();
        }


        private void rdoLeaderboard_Click(object sender, EventArgs e)
        {
            rdoLeaderboard.Checked = !rdoLeaderboard.Checked;
            User.CurrentUser.Settings.IsShownOnLeaderboard = rdoLeaderboard.Checked;
            UserDatabase.Instance.Write();
        }
    }
}
