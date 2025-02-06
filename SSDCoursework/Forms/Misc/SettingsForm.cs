using SSDCoursework.Classes.UserClasses;
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

            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\UserImages\"; 
            if (Directory.Exists(appPath) == false)                                              
            {                                                                                    
                Directory.CreateDirectory(appPath);                                              
            }                                                                                    

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = opFile.SafeFileName;   
                    string filepath = opFile.FileName;    
                    File.Copy(filepath, appPath + iName);
                    Bitmap pfp = new Bitmap(opFile.OpenFile());

                    pictureBox1.Image = pfp;
                    User.CurrentUser.Settings.AddPFP(pfp, appPath + iName);
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

        }
    }
}
