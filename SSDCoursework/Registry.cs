using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework
{
    public partial class Registry : Form
    {
        bool sidebarExpanding = true; //starts small first
        int sidebarChange = 12;
        Form activeChildForm = null;

        public Registry()
        {
            InitializeComponent();
            InitialiseTimer();
        }

        void InitialiseTimer()
        {
            sidebarTimer.Interval = 10;
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if(sidebarExpanding)
            {
                flpSidebar.Width += sidebarChange;
                if(flpSidebar.Width == flpSidebar.MaximumSize.Width)
                {
                    sidebarExpanding = false;
                    sidebarTimer.Stop();
                }
            }
            else
            { 
                flpSidebar.Width -= sidebarChange;
                if(flpSidebar.Width == flpSidebar.MinimumSize.Width)
                {
                    sidebarExpanding = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void pbxHamburger_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void OpenChildForm(Form newChildForm)
        {
            if(activeChildForm != null)
            {
                activeChildForm.Close();
                pnlChildFormHolder.Controls.Clear();
            }
            activeChildForm = newChildForm;
            activeChildForm.TopLevel = false;
            activeChildForm.FormBorderStyle = FormBorderStyle.None;
            activeChildForm.Dock = DockStyle.Fill;
            activeChildForm.BringToFront();
            pnlChildFormHolder.Controls.Add(newChildForm);
            activeChildForm.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Login());
        }

        private void Registry_Resize(object sender, EventArgs e)
        {
            pnlChildFormHolder.Width = this.Width - 50;
            pnlChildFormHolder.Height = this.Height;
        }

        private void pnlChildFormHolder_Resize(object sender, EventArgs e)
        {
            pnlChildFormHolder.Controls[0].Width = pnlChildFormHolder.Width;
            pnlChildFormHolder.Controls[0].Height = pnlChildFormHolder.Height;
        }
    }
}
