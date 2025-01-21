using SSDCoursework.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework.Forms.MainMenu.Arcade
{
    public partial class Arithmetic : Form
    {
        public Arithmetic()
        {
            InitializeComponent();
        }

        private void gameBannerControl1_Load(object sender, EventArgs e)
        {
            gameBannerControl1.LblGameIndicator.Text = "Arithmetic";
        }
    }
}
