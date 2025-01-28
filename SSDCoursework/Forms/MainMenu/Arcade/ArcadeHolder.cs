using SSDCoursework.Forms.Misc;
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
    public partial class ArcadeHolder : Form
    {
        public ArcadeHolder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (Application.OpenForms[0] as SplashScreen).Reset(6, new Arithmetic());
        }
    }
}
