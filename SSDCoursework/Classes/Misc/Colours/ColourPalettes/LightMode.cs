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
        public override Dictionary<string, Color> PaletteHash { get; } = new Dictionary<string, Color>();

        public LightMode()
        {
            PaletteHash["MainColour"] = Color.White;
            PaletteHash["Accent1"] = Color.FromArgb(52, 76, 132);
            PaletteHash["Accent2"] = Color.DarkSlateGray;
            PaletteHash["Accent3"] = Color.DimGray;
            PaletteHash["ButtonAccent"] = Color.Black;
            PaletteHash["TextColour"] = Color.White;
        }

        public override string ToString()
        {
            return "LightMode";
        }
    }
}
