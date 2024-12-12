using System;
using System.Drawing;
using System.Windows.Forms;

namespace SSDCoursework
{
    public partial class SidebarControl : UserControl
    {
        const int sidebarExpandedWidth = 250; //Expanded size
        const int sidebarCollapsedWidth = 68; //Collapsed size
        const int sidebarScaleExpansionFactor = 80; //This controls the rate of increase of the panel. The smaller it is, the quicker the panel grows/shrinks.

        bool isSidebarExpanded = false; //Flag that tracks the current state of the sidebar
        bool expandingForMenuItem = false; //Flag that tracks if an option has been selected

        int sidebarSpeedMult = 1;//Adjusted when the user clicks an option from the sidebar (moves faster when a menu option is selected).
        int sidebarChange; //This is adjusted using the sidebarScaleExpansionFactor to find the exact length the sidebar needs to expand

        Form holderForm; //Holds the form that this object is found in
        Form activeChildForm; //Holds the current active form in the child form holder

        public bool IsSidebarExpanded
        {
            get { return isSidebarExpanded; }
            set { isSidebarExpanded = value; }
        }

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

        public SidebarControl(Form holderForm)
        {
            InitializeComponent();
            this.holderForm = holderForm;
            flpSidebar.MaximumSize = this.MaximumSize;
            sidebarChange = this.Width / sidebarScaleExpansionFactor;
        }

        public void AddControl(string text, string imagePath, EventHandler clickEventHandler) 
        { 
            Control control = SidebarButtonCreation(text, imagePath, clickEventHandler);
            flpSidebar.Controls.Add(control);
        }

        Control SidebarButtonCreation(string text, string imagePath, EventHandler clickEventHandler)
        {
            Button newButton = new Button()
            {
                AutoSize = true,
                Width = sidebarExpandedWidth,
                Height = 100,
                Text = text,
                TextAlign = ContentAlignment.MiddleRight,
                FlatStyle = FlatStyle.Flat,
                Padding = new Padding(0, 0, 40, 0),
                Dock = DockStyle.Left,
                FlatAppearance = { BorderSize = 0 }, // Remove the border
                BackColor = flpSidebar.BackColor, // Background color of the button
                ForeColor = Color.White // Text color
            };
            newButton.Click += clickEventHandler;

            Panel newPanel = new Panel
            {
                Width = sidebarExpandedWidth,
                Height = 100,
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
            activeChildForm.TopLevel = false;
            activeChildForm.FormBorderStyle = FormBorderStyle.None;
            activeChildForm.Dock = DockStyle.Fill;
            activeChildForm.BringToFront();
            pnlChildFormHolder.Controls.Add(newChildForm);
            activeChildForm.Show();
        }

        private void SidebarControl_Resize(object sender, EventArgs e)
        {
            Size = holderForm.Size;
            pnlChildFormHolder.Width = holderForm.Width - sidebarCollapsedWidth - 16;
            sidebarChange = Width / sidebarScaleExpansionFactor;
        }
    }
}
