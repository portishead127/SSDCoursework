using SSDCoursework.Classes.UserClasses;
using SSDCoursework.Forms.MainMenu.Arcade;
using SSDCoursework.Forms.MainMenu.QuizMenu;
using SSDCoursework.Forms.Misc;
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

            if (User.CurrentUser.IsAdmin)
            {
                sidebar.AddControl("Admin Options", Properties.Resources.Hamburger, AdminOptions_Click);
            }
            sidebar.AddControl("Leaderboard", Properties.Resources.SignUpSymbol, btnLeaderboard_Click);
            sidebar.AddControl("Formula Playground", Properties.Resources.LoginSymbol, FormulaPlayground_Click);
            sidebar.AddControl("Quizzes", Properties.Resources.SignUpSymbol, Quizzes_Click);
        }

        void Quizzes_Click(object sender, EventArgs e)
        {
            sidebar.IsExpandingForMenuItem = true;
            sidebar.FormToOpen = new QuizMenuHolder();
            sidebar.sidebarTimer.Start();
        }

        void AdminOptions_Click(object sender, EventArgs e)
        {
            sidebar.IsExpandingForMenuItem = true;
            sidebar.FormToOpen = new AdminOptions();
            sidebar.sidebarTimer.Start();
        }

        void FormulaPlayground_Click(object sender, EventArgs e)
        {
            (Application.OpenForms[0] as SplashScreen).Reset(10, new DragAndDropQuiz());
        }
        
        void btnLeaderboard_Click(object sender, EventArgs e)
        {
            sidebar.IsExpandingForMenuItem= true;
            sidebar.FormToOpen = new Leaderboard();
            sidebar.sidebarTimer.Start();
        }
    }
}
