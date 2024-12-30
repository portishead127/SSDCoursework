using System;
using System.Drawing;
using System.Windows.Forms;

namespace SSDCoursework
{
    public partial class SidebarControl : UserControl
    {
        const int sidebarExpandedWidth = 250; //Expanded size
        const int sidebarCollapsedWidth = 120; //Collapsed size
        const int sidebarScaleExpansionFactor = 80; //This controls the rate of increase of the panel. The smaller it is, the quicker the panel grows/shrinks.

        readonly int buttonHeight = 90;

        bool isSidebarExpanded = false; //Flag that tracks the current state of the sidebar
        bool expandingForMenuItem = false; //Flag that tracks if an option has been selected

        int sidebarSpeedMult = 1;//Adjusted when the user clicks an option from the sidebar (moves faster when a menu option is selected).
        int sidebarChange; //This is adjusted using the sidebarScaleExpansionFactor to find the exact length the sidebar needs to expand

        Form activeChildForm; //Holds the current active form in the child form holder panel

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

        public Form FormToOpen { get; set; } //This is a temporary variable that stores what form should be opened, it is mostly referenced outside the class


        public SidebarControl()
        {
            InitializeComponent();
            Console.Write(pbxHamburger.Image.Size.ToString());
            Size = Screen.PrimaryScreen.Bounds.Size;
            lblPageIndicator.Text = "Registry";
            flpSidebar.MaximumSize = MaximumSize;
            pnlChildFormHolder.Width = Width - flpSidebar.Width;
            pnlChildFormHolder.Height = Height - flpBannerbar.Size.Height;
            sidebarChange = Width / sidebarScaleExpansionFactor;
        }

        public void AddControl(string text, Bitmap image, EventHandler clickEventHandler)
        {
            Control control = SidebarButtonCreation(text, image, clickEventHandler);
            flpSidebar.Controls.Add(control);
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

            Panel newPanel = new Panel
            {
                Width = sidebarExpandedWidth,
                Height = buttonHeight,
                Padding = new Padding(0),
                Dock = DockStyle.Left
            };
            newPanel.Controls.Add(newButton);
            return newPanel;
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (expandingForMenuItem)
            {
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
            lblPageIndicator.Text = newChildForm.Text;
            activeChildForm.TopLevel = false;
            activeChildForm.FormBorderStyle = FormBorderStyle.None;
            activeChildForm.Dock = DockStyle.Fill;
            activeChildForm.BringToFront();
            pnlChildFormHolder.Controls.Add(newChildForm);
            activeChildForm.Show();
        }
    }
}
