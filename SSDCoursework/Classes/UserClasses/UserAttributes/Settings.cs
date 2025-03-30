using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.Misc;
using SSDCoursework.Classes.Misc.Colours;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework.Classes.UserClasses.UserAttributes
{
    internal class Settings
    {
        public static string UserImagesDirectory = Path.GetDirectoryName(Application.ExecutablePath) + @"\UserImages\"; //Directory used to store user images.
        public ColourPalette ColourPalette { get; set; }
        public string PFPPath { get; set; }
        public Image PFP { get; set; }
        public bool IsShownOnLeaderboard { get; set; }

        /// <summary>
        /// Creates a default settings object.
        /// </summary>
        public Settings() 
        {
            ColourPalette = new DarkMode();
            PFPPath = string.Empty;
            PFP = Properties.Resources.EmptyProfilePic;
            IsShownOnLeaderboard = true;
        }

        public Settings(ColourPalette colourPalette, string pFPPath, bool isShownOnLeaderboard)
        {
            ColourPalette = colourPalette;
            PFPPath = pFPPath;
            if(pFPPath != string.Empty)
            {
                PFP = Bitmap.FromFile(PFPPath);
            }
            else
            {
                PFP = Properties.Resources.EmptyProfilePic;
            }
            
            IsShownOnLeaderboard = isShownOnLeaderboard;
        }
        
        public void AddPFP(Bitmap pfp, string pfpPath)
        {
            PFP = pfp;
            PFPPath = pfpPath;
            UserDatabase.Instance.Write();
        }

        public void RemovePFP()
        {
            if(PFP != null)
            {
                PFP.Dispose();
                PFP = null;
                PFPPath = string.Empty;
            }
            UserDatabase.Instance.Write();
        }
    }
}
