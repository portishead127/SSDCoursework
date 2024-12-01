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
        bool isSidebarExpanded = false;
        bool expandingForMenuItem = false;
        int sidebarChange;
        int sidebarScaleExpansionFactor = 80;
        int sidebarSpeedMult = 1;
        Form activeChildForm = null;
        int sidebarExpandedWidth = 250;
        int sidebarCollapsedWidth = 68;

        public Registry()
        {
            InitializeComponent();
            InitialiseTimer();
            flpSidebar.MaximumSize = this.MaximumSize;
            sidebarChange = this.Width / sidebarScaleExpansionFactor;
        }

        void InitialiseTimer()
        {
            sidebarTimer.Interval = 5;
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            int fullExpandWidth = this.Width; // Sidebar expands fully for menu item selection

            if (expandingForMenuItem)
            {
                // Expand to full screen width
                flpSidebar.Width += sidebarChange * sidebarSpeedMult;
                if (flpSidebar.Width >= fullExpandWidth)
                {
                    flpSidebar.Width = fullExpandWidth; // Ensure exact size
                    sidebarTimer.Stop();
                    expandingForMenuItem = false;

                    // Start collapsing the sidebar after opening the form
                    OpenChildForm(new SignUp());
                    isSidebarExpanded = true;
                    sidebarTimer.Start();
                }
                return;
            }

            if (isSidebarExpanded)
            {
                flpSidebar.Width -= sidebarChange * sidebarSpeedMult;
                if (flpSidebar.Width <= sidebarCollapsedWidth)
                {
                    flpSidebar.Width = sidebarCollapsedWidth;
                    isSidebarExpanded = false;
                    sidebarTimer.Stop();
                    sidebarSpeedMult = 1;
                }
            }
            else
            {
                flpSidebar.Width += sidebarChange * sidebarSpeedMult;
                if (flpSidebar.Width >= sidebarExpandedWidth)
                {
                    flpSidebar.Width = sidebarExpandedWidth;
                    isSidebarExpanded = true;
                    sidebarTimer.Stop();
                    sidebarSpeedMult = 1;
                }
            }
        }

        private void pbxHamburger_Click(object sender, EventArgs e)
        {
            expandingForMenuItem = false;
            sidebarTimer.Start();
        }

        private void OpenChildForm(Form newChildForm)
        {
            if (activeChildForm != null)
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
            expandingForMenuItem = true;
            sidebarSpeedMult = 3;
            sidebarTimer.Start();
        }

        private void Registry_Resize(object sender, EventArgs e)
        {
            sidebarChange = this.Width / sidebarScaleExpansionFactor;
        }
    }
}
