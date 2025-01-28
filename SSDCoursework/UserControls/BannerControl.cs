using SSDCoursework.Forms.MainMenu;
using SSDCoursework.Forms.Misc;
using System;
using System.Windows.Forms;

namespace SSDCoursework.UserControls
{
    public partial class GameBannerControl : UserControl
    {
        public GameBannerControl()
        {
            InitializeComponent();
        }

        private void pbxExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Quit game?", "Quit?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                (Application.OpenForms[0] as SplashScreen).Reset(3, new MainMenuHolder());
            }
        }

        private void GameBannerControl_Load(object sender, EventArgs e)
        {
            lblGameIndicator.Text = FindForm().Text;
        }
    }
}
