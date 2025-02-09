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
            
            if(User.CurrentUser.Settings.PFP != null)
            {
                pictureBox1.Image = User.CurrentUser.Settings.PFP;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.EmptyProfilePic;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User.CurrentUser.ChangePass(User.CurrentUser, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User.CurrentUser.ChangeUsername(User.CurrentUser, textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
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

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            User.CurrentUser.Settings.RemovePFP();
        }
    }
}
