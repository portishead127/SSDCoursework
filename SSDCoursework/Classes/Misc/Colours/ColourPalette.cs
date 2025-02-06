using SSDCoursework.Classes.Misc.Colours;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.Misc
{
    internal abstract class ColourPalette
    {
        protected Color MainColour { get; set; }
        protected Color Accent1 { get; set; }
        protected Color Accent2 { get; set; }
        
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
                throw new Exception("Could not parse colour palette");
            }
        }
    }
}
