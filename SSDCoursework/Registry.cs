using System;
using System.Windows.Forms;

namespace SSDCoursework
{
    public partial class Registry : Form
    {
        SidebarControl sidebar;

        public Registry()
        {
            InitializeComponent();
            InitialiseSidebar();
        }

        void InitialiseSidebar()
        {
            sidebar = new SidebarControl();
            sidebar.Dock = DockStyle.Fill;
            Controls.Add(sidebar);

            // Add dynamic content
            sidebar.AddControl("Sign Up", "C:\\Users\\aaron\\Documents\\School\\SSD\\Projects\\SSDCoursework\\SSDCoursework\\Resources\\Login symbol2.png", btnSignUp_Click);
            sidebar.AddControl("Login", "C:\\Users\\aaron\\Documents\\School\\SSD\\Projects\\SSDCoursework\\SSDCoursework\\Resources\\Login symbol2.png", btnLogin_Click);
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
