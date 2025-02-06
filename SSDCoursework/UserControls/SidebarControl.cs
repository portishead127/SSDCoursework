using SSDCoursework.Forms;
using SSDCoursework.Forms.Misc;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SSDCoursework.UserControls
{
    public partial class SidebarControl : UserControl
    {
        const int sidebarExpandedWidth = 250; //Expanded size
        const int sidebarCollapsedWidth = 120; //Collapsed size
        const int sidebarScaleExpansionFactor = 80; //This controls the rate of increase of the panel. The smaller it is, the quicker the panel grows/shrinks.

        const int buttonHeight = 100;

        bool isSidebarExpanded = false; //Flag that tracks the current state of the sidebar.
        bool expandingForMenuItem = false; //Flag that tracks if an option has been selected.

        int sidebarSpeedMult = 1;//Adjusted when the user clicks an option from the sidebar (moves faster when a menu option is selected).
        int sidebarChange; //This is adjusted using the sidebarScaleExpansionFactor to find the exact length the sidebar needs to expand.

        Form activeChildForm; //Holds the current active form in the child form holder panel.

        public bool IsExpandingForMenuItem
        {
            get { return expandingForMenuItem; }
            set { expandingForMenuItem = value; }
        }

        public int SidebarSpeedMult
        {
            get { return sidebarSpeedMult; }
            set { sidebarSpeedMult = value; }
        }

        public Form FormToOpen { get; set; } //This is a temporary variable that stores what form should be opened, it is mostly referenced outside the class.

        public SidebarControl()
        {
            InitializeComponent();
            Size = Screen.PrimaryScreen.Bounds.Size;
            flpSidebar.MaximumSize = MaximumSize;
            pnlFormHolder.Width = Width - flpSidebar.Width;
            pnlFormHolder.Height = Height - flpBannerbar.Size.Height;
            sidebarChange = Width / sidebarScaleExpansionFactor;
            DoubleBuffered = true;
        }

        public void AddControl(string text, Bitmap image, EventHandler clickEventHandler)
        {
            Control control = SidebarButtonCreation(text, image, clickEventHandler);
            flpSidebar.Controls.Add(control);
            flpSidebar.Controls.SetChildIndex(control, 1);
            pnlEmptySpace.Height -= buttonHeight + 5;
        }

        Control SidebarButtonCreation(string text, Bitmap image, EventHandler clickEventHandler)
        {
            PictureBox newPictureBox = new PictureBox()
            {
                Image = image,
                Padding = Padding.Empty,
                Enabled = false,
                SizeMode = PictureBoxSizeMode.Zoom,
                Height = buttonHeight,
                BackColor = Color.Transparent
            };
            
            Button newButton = new Button()
            {
                AutoSize = true,
                Width = sidebarExpandedWidth,
                Height = buttonHeight,
                Text = text,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleRight,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(13, 19, 33),
                Padding = new Padding(0, 0, 20, 0),
                Dock = DockStyle.Left,
                Cursor = Cursors.Hand,
                FlatAppearance = { BorderSize = 0, MouseOverBackColor = Color.Transparent, MouseDownBackColor = Color.Transparent}
            };

            newButton.Controls.Add(newPictureBox);
            newButton.Click += clickEventHandler;
            return newButton;
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (expandingForMenuItem)
            {
                sidebarSpeedMult = 3;
                // Expand to full screen width
                flpSidebar.Width += sidebarChange * sidebarSpeedMult;
                if (flpSidebar.Width >= Width)
                {
                    flpSidebar.Width = Width; // Ensure exact size
                    sidebarTimer.Stop();

                    // Start collapsing the sidebar after opening the form
                    OpenChildForm(FormToOpen);
                    expandingForMenuItem = false;
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
            Console.WriteLine(pnlFormHolder.Size.ToString());
            expandingForMenuItem = false;
            sidebarTimer.Start();
        }

        private void OpenChildForm(Form newChildForm)
        {
            if (activeChildForm != null)
            {
                activeChildForm.Close();
                pnlFormHolder.Controls.Clear();
            }
            activeChildForm = newChildForm;
            lblPageIndicator.Text = newChildForm.Text;
            activeChildForm.TopLevel = false;
            activeChildForm.FormBorderStyle = FormBorderStyle.None;
            activeChildForm.Dock = DockStyle.Fill;
            activeChildForm.BringToFront();
            pnlFormHolder.Controls.Add(newChildForm);
            activeChildForm.Show();
        }

        private void pbxSettingsIcon_Click(object sender, EventArgs e)
        {
            expandingForMenuItem = true;
            FormToOpen = new SettingsForm();
            sidebarTimer.Start();
        }

        private void pbxExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =  MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SidebarControl_Load(object sender, EventArgs e)
        {
            lblPageIndicator.Text = FindForm().Text;
        }
    }
}
