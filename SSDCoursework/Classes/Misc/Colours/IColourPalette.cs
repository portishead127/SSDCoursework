using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.Misc
{
    internal interface IColourPalette
    {
        Color MainColour { get; set; }    
        Color Accent1 { get; set; }    
        Color Accent2 { get; set; }     
    }
}
