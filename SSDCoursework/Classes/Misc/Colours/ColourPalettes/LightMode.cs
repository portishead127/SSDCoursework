using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.Misc.Colours
{
    internal class LightMode : IColourPalette
    {
        public Color MainColour { get; set; }
        public Color Accent1 {  get; set; }
        public Color Accent2 {  get; set; }

        public LightMode()
        {
            MainColour = Color.FromArgb(255, 255, 255);
            Accent1 = Color.FromArgb(255, 255, 255);
            Accent2 = Color.FromArgb(255, 255, 255);
        }
    }
}
