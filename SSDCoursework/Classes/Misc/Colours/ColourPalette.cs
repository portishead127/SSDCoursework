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
        protected Dictionary<string, Color> PaletteHash = new Dictionary<string, Color>()
        {
            {"MainColour", Color.Purple},
            {"Accent1", Color.Purple },
            {"Accent2", Color.Purple }
        };
        
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
