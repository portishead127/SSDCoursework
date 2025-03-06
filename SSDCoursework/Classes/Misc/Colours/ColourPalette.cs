using SSDCoursework.Classes.Misc.Colours;
using SSDCoursework.Classes.UserClasses;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework.Classes.Misc
{
    internal abstract class ColourPalette
    {
        public abstract Dictionary<string, Color> PaletteHash { get; }

        public static ColourPalette Parse(string colourPaletteName)
        {
            if (colourPaletteName == "DarkMode")
            {
                return new DarkMode();
            }
            else if (colourPaletteName == "LightMode")
            {
                return new LightMode();
            }
            else
            {
                throw new Exception("Could not parse colour palette.");
            }
        }

        public void ApplyFormColour(Form form)
        {
            // Apply colour to the form itself
            if (form.Tag != null && PaletteHash.TryGetValue(form.Tag.ToString(), out Color formColor))
            {
                form.BackColor = formColor;
            }
        }

        public void ApplyColour(Control.ControlCollection controls, Form form)
        {
            ApplyFormColour(form);
            ApplyColour(controls);
        }

        public void ApplyColour(Control.ControlCollection controls)
        {
            // Apply colours to controls
            foreach (Control c in controls)
            {
                if (c.Tag == null) continue;

                if (c.GetType() == typeof(TableLayoutPanel) || c.GetType() == typeof(Panel))
                {
                    ApplyColour(c.Controls);
                }

                ParseTag(c);
                
            }
        }

        private void ParseTag(Control c)
        {
            if (c.Tag == null) return;

            switch (c.Tag.ToString())
            {
                case "MainColour":
                    c.BackColor = PaletteHash["MainColour"];
                    break;
                case "Accent1":
                    c.BackColor = PaletteHash["Accent1"];
                    break;
                case "Accent2":
                    c.BackColor = PaletteHash["Accent2"];
                    break;
                case "ButtonAccent":
                    c.BackColor = PaletteHash["ButtonAccent"];
                    break; 
            }

            if (c.Tag.ToString().Contains("ButtonAccent"))
            {
                c.ForeColor = PaletteHash["ButtonTextColour"];
            }
            else
            {
                c.ForeColor = PaletteHash["TextColour"];
            }
        }
    }
}
