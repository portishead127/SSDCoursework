using SSDCoursework.Classes.Misc;
using SSDCoursework.Classes.Misc.Colours;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.UserClasses.UserAttributes
{
    internal class Settings
    {
        public ColourPalette ColourPalette {  get; set; }
        public string PFPPath { get; set; }
        public Bitmap PFP { get; set; }
        public bool IsShownOnLeaderboard { get; set; }

        /// <summary>
        /// Creates a default settings object.
        /// </summary>
        public Settings() 
        {
            ColourPalette = new DarkMode();
        }

        public Settings(ColourPalette colourPalette, string pFPPath, Bitmap pFP, bool isShownOnLeaderboard)
        {
            ColourPalette = colourPalette;
            PFPPath = pFPPath;
            PFP = pFP;
            IsShownOnLeaderboard = isShownOnLeaderboard;
        }
        
        public void AddPFP(Bitmap pfp, string pfpPath)
        {
            PFP = pfp;
            PFPPath = pfpPath;
        }

        public void RemovePFP()
        {
            if(PFP != null)
            {
                File.Delete(PFPPath);
                PFP.Dispose();
                PFP = null;
                PFPPath = null;
            }
        }
    }
}
