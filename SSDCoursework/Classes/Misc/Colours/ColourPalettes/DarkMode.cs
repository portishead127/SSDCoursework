using System.Collections.Generic;
using System.Drawing;

namespace SSDCoursework.Classes.Misc.Colours
{
    internal class DarkMode : ColourPalette
    {
        public override Dictionary<string, Color> PaletteHash { get; } = new Dictionary<string, Color>();

        public DarkMode()
        {
            PaletteHash["MainColour"] = Color.FromArgb(7, 10, 25);
            PaletteHash["Accent1"] = Color.FromArgb(52, 76, 132);
            PaletteHash["Accent2"] = Color.DarkSlateGray;
            PaletteHash["Accent3"] = Color.DimGray;
            PaletteHash["ButtonAccent"] = Color.Silver;
            PaletteHash["ButtonTextColour"] = Color.Black;
            PaletteHash["TextColour"] = Color.White;
        }

        public override string ToString()
        {
            return "DarkMode";
        }
    }
}
