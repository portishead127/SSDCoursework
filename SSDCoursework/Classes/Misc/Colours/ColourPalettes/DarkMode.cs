using System.Drawing;

namespace SSDCoursework.Classes.Misc.Colours
{
    internal class DarkMode : ColourPalette
    {
        public DarkMode()
        {
            MainColour = Color.FromArgb(0,0,0);
            Accent1 = Color.FromArgb(0,0,0);
            Accent2 = Color.FromArgb(0,0,0);
        }

        public override string ToString()
        {
            return "DarkMode";
        }
    }
}
