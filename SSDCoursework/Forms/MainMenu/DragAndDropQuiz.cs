using SSDCoursework.Classes.Misc;
using SSDCoursework.Classes.QuestionClasses;
using SSDCoursework.Classes.UserClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SSDCoursework.Forms.MainMenu.Arcade
{
    public partial class DragAndDropQuiz : Form
    {
        string explanation;
        Dictionary<string, string> dragDropResults = new Dictionary<string, string>()
        {
            { "Fma", "F = ma is a formula used to calculate the force that would accelerate a body of 'm' kilograms a meters per second per second.\n\nF - Resultant force/Newtons\nm - Mass/kilograms\na - Acceleration/meters per second per second" },
            { "PFv", "P = Fv is a formula used to calculate the power generated when a force moves an object at a certain velocity.\n\nP - Power/Watts\nF - Force/Newtons\nv - Velocity/meters per second" },
            { "pmv", "p = mv is a formula used to calculate the momentum of an object based on its mass and velocity.\n\np - Momentum/kilogram meters per second\nm - Mass/kilograms\nv - Velocity/meters per second" },
            { "Qmc", "Q = mc is a formula used to calculate the heat energy transferred to a substance based on its mass and specific heat capacity.\n\nQ - Heat energy/Joules\nm - Mass/kilograms\nc - Specific heat capacity/Joules per kilogram per Kelvin" },
            { "VIR", "V = IR is a formula used to calculate the voltage across a resistor given the current flowing through it and its resistance.\n\nV - Voltage/Volts\nI - Current/Amperes\nR - Resistance/Ohms" },
            { "PIV", "P = IV is a formula used to calculate the power dissipated in an electrical circuit given the current and voltage.\n\nP - Power/Watts\nI - Current/Amperes\nV - Voltage/Volts" },
        };

        public DragAndDropQuiz()
        {
            InitializeComponent();
            User.CurrentUser.Settings.ColourPalette.ApplyColour(this.Controls, this);
            CheckResult();
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && sender is Label lbl && !string.IsNullOrEmpty(lbl.Text))
            {
                DataObject data = new DataObject();
                data.SetData(DataFormats.StringFormat, lbl.Text);

                lbl.DoDragDrop(data, DragDropEffects.Move);
            }
        }

        private void Label_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void Label_DragDrop(object sender, DragEventArgs e)
        {
            if (sender is Label lbl)
            {
                if (e.Data.GetDataPresent(DataFormats.StringFormat))
                {
                    lbl.Text = (string)e.Data.GetData(DataFormats.StringFormat);
                    lbl.Refresh();  // Ensure UI updates before checking
                }
            }
            Application.DoEvents(); // Allow UI changes to process
            CheckResult();
        }


        private void CheckResult()
        {
            try
            {
                explanation = dragDropResults[lblResult.Text.ToString()+lblSecond.Text.ToString()+lblThird.Text.ToString()];
            }
            catch
            {
                explanation = "Try playing around with different symbols to find a valid formula!";
            }
            lblExplanation.Text = explanation;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
