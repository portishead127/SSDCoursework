using System.Drawing;

namespace SSDCoursework.Classes.Misc.Colours
{
    internal class DarkMode : IColourPalette
    {
        public Color MainColour { get; set; }
        public Color Accent1 { get; set; }
        public Color Accent2 { get; set; }

        public DarkMode()
        {
            MainColour = Color.FromArgb(0,0,0);
            Accent1 = Color.FromArgb(0,0,0);
            Accent2 = Color.FromArgb(0,0,0);
        }
    }
}
