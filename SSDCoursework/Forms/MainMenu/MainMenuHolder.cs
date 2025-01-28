using SSDCoursework.Classes.UserClasses;
using SSDCoursework.Forms.MainMenu.Arcade;
using SSDCoursework.Forms.MainMenu.QuizMenu;
using SSDCoursework.Forms.Registry;
using SSDCoursework.UserControls;
using System;
using System.Windows.Forms;

namespace SSDCoursework.Forms.MainMenu
{
    public partial class MainMenuHolder : Form
    {
        SidebarControl sidebar;

        public MainMenuHolder()
        {
            InitialiseSidebar();
            InitializeComponent();
        }

        void InitialiseSidebar()
        {
            sidebar = new SidebarControl();
            sidebar.Dock = DockStyle.Fill;
            Controls.Add(sidebar);

            sidebar.AddControl("Quizzes", Properties.Resources.SignUpSymbol, btnSignUp_Click);
            sidebar.AddControl("Arcade", Properties.Resources.LoginSymbol, btnLogin_Click);
            if (User.CurrentUser.IsAdmin)
            {
                sidebar.AddControl("Admin Options", Properties.Resources.Hamburger, btnLogin_Click);
            }
        }

        void btnSignUp_Click(object sender, EventArgs e)
        {
            sidebar.IsExpandingForMenuItem = true;
            sidebar.FormToOpen = new QuizMenuHolder();
            sidebar.sidebarTimer.Start();
        }

        void btnLogin_Click(object sender, EventArgs e)
        {
            sidebar.IsExpandingForMenuItem = true;
            sidebar.FormToOpen = new Arcade.ArcadeHolder();
            sidebar.sidebarTimer.Start();
        }
    }
}
