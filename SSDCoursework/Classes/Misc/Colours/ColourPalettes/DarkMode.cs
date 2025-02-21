using System.Collections.Generic;
using System.Drawing;

namespace SSDCoursework.Classes.Misc.Colours
{
    internal class DarkMode : ColourPalette
    {
        protected override Dictionary<string, Color> PaletteHash { get; } = new Dictionary<string, Color>();

        public DarkMode()
        {
            PaletteHash["MainColour"] = Color.DarkSlateBlue;
            PaletteHash["Accent1"] = Color.FromArgb(52, 76, 132);
            PaletteHash["Accent2"] = Color.DarkSlateGray;
            PaletteHash["Accent3"] = Color.DimGray;
            PaletteHash["ButtonAccent"] = Color.Silver;
            PaletteHash["TextColour"] = Color.Black;
        }

        public override string ToString()
        {
            return "DarkMode";
        }
    }
}
