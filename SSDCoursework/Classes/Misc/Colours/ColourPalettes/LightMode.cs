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
            PaletteHash["MainColour"] = Color.WhiteSmoke;
            PaletteHash["Accent1"] = Color.FromArgb(52, 76, 132);
            PaletteHash["Accent2"] = Color.LightCyan;
            PaletteHash["Accent3"] = Color.LightBlue;
            PaletteHash["ButtonAccent"] = Color.MintCream;
            PaletteHash["ButtonTextColour"] = Color.Black;
            PaletteHash["TextColour"] = Color.Black;
        }

        public override string ToString()
        {
            return "LightMode";
        }
    }
}
