using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SSDCoursework
{
    public partial class RegistryHolder : Form
    {
        SidebarControl sidebar;

        public RegistryHolder()
        {
            InitializeComponent();
            InitialiseSidebar();
        }

        void InitialiseSidebar()
        {
            sidebar = new SidebarControl();
            sidebar.Dock = DockStyle.Fill;
            Controls.Add(sidebar);

            sidebar.AddControl("Sign up", Properties.Resources.SignUpSymbol, btnSignUp_Click);
            sidebar.AddControl("Login", Properties.Resources.LoginSymbol, btnLogin_Click);
        }

        void btnSignUp_Click(object sender, EventArgs e)
        {
            sidebar.IsExpandingForMenuItem = true;
            sidebar.SidebarSpeedMult = 3;
            sidebar.FormToOpen = new SignUp();
            sidebar.sidebarTimer.Start();
        }

        void btnLogin_Click(object sender, EventArgs e)
        {
            sidebar.IsExpandingForMenuItem = true;
            sidebar.SidebarSpeedMult = 3;
            sidebar.FormToOpen = new Login();
            sidebar.sidebarTimer.Start();
        }
    }
}
