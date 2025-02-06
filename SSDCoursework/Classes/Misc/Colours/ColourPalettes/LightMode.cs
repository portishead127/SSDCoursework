using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.Misc.Colours
{
    internal class LightMode : ColourPalette
    {
        public LightMode()
        {
            MainColour = Color.FromArgb(255, 255, 255);
            Accent1 = Color.FromArgb(255, 255, 255);
            Accent2 = Color.FromArgb(255, 255, 255);
        }

        public override string ToString()
        {
            return "LightMode";
        }
    }
}
