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
                return new DarkMode();
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
            ApplyControlsColour(controls);
        }

        public void ApplyControlsColour(Control.ControlCollection controls)
        {
            // Apply colours to controls
            foreach (Control c in controls)
            {
                ApplyControlColour(c);
            }
        }

        public void ApplyControlColour(Control c)
        {
            if (c.Tag == null || c.Tag.ToString().Contains("exempt"))
            {
                return;
            }

            c.ForeColor = PaletteHash["TextColour"];

            if (c.GetType() == typeof(TableLayoutPanel) || c.GetType() == typeof(Panel))
            {
                ApplyControlsColour(c.Controls);
            }

            ParseTag(c);
        }

        private void ParseTag(Control c)
        {
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
                default:
                    break;
            }

            if (c.Tag.ToString().Contains("ButtonAccent"))
            {
                c.ForeColor = PaletteHash["ButtonTextColour"];
            } 
        }
    }
}
