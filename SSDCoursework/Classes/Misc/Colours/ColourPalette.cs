using SSDCoursework.Classes.Misc.Colours;
using SSDCoursework.Classes.UserClasses;
using System;
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
        protected abstract Dictionary<string, Color> PaletteHash { get; }

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

        public void ApplyColour(Form form)
        {
            // Apply colour to the form itself
            if (form.Tag != null && PaletteHash.TryGetValue(form.Tag.ToString(), out Color formColor))
            {
                form.BackColor = formColor;
            }

            // Apply colours to controls
            foreach (Control c in form.Controls)
            {
                c.ForeColor = PaletteHash["TextColour"];

                if (c.Tag == null) continue;

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
                }
            }
        }
    }
}
