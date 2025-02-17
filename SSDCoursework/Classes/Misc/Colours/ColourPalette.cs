using SSDCoursework.Classes.Misc.Colours;
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
            if(colourPaletteName == "DarkMode")
            {
                return new DarkMode();
            }
            else if(colourPaletteName == "LightMode")
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
            foreach(Control c in form.Controls)
            {
                if(c.Tag.ToString().Contains("MainColour"))
                {
                    c.BackColor = PaletteHash["MainColour"];
                }
                else if (c.Tag.ToString().Contains("Accent1"))
                {
                    c.BackColor = PaletteHash["Accent1"];
                }
                else if (c.Tag.ToString().Contains("Accent2"))
                {
                    c.BackColor = PaletteHash["Accent2"];
                }
            }
        }
    }
}
