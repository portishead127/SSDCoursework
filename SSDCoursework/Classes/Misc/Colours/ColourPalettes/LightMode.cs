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
        protected override Dictionary<string, Color> PaletteHash { get; } = new Dictionary<string, Color>();

        public LightMode()
        {
            PaletteHash["MainColour"] = Color.White;
            PaletteHash["Accent1"] = Color.Blue;
            PaletteHash["Accent2"] = Color.White;
        }

        public override string ToString()
        {
            return "LightMode";
        }
    }
}
