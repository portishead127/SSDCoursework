using System.Collections.Generic;
using System.Drawing;

namespace SSDCoursework.Classes.Misc.Colours
{
    internal class DarkMode : ColourPalette
    {
        protected override Dictionary<string, Color> PaletteHash { get; } = new Dictionary<string, Color>();

        public DarkMode()
        {
            PaletteHash["MainColour"] = Color.Black;
            PaletteHash["Accent1"] = Color.Blue;
            PaletteHash["Accent2"] = Color.Black;
        }

        public override string ToString()
        {
            return "DarkMode";
        }
    }
}
