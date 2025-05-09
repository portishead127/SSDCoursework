﻿using System;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework.Forms.Misc
{
    public partial class SplashScreen : Form
    {
        int maxProgressUpdate;
        const double transparencyUpdate = 0.2;
        const int timeMultiplier = 20;
        bool isOpening = true; //Will be opening on creation.
        Form formToOpen;

        string[] taglines = new string[]
        {
            "\"Not quite Duolingo.\"",
            "\"100% bug-free!\"",
            "\"May the mass X acceleration be with you.\"",
            "\"Keyboard and mouse sold seperately.\"",
            "\"Built for thinkers, not clickers.\"", 
            "\"Testing your brain, not your patience.\"", 
            "\"The first computer mouse was made of wood in 1964.\"", 
            "\"There are more possible ways to shuffle a deck of cards than there are atoms on Earth.\"",
            "\"The moon is slowly moving away from Earth—about 1.5 inches per year.\"",
            "\"The Golden Gate Bridge cables contain enough steel to circle the Earth three times.\"",
            "\"Your body contains enough carbon to fill 9,000 pencils.\"",
        };

        public SplashScreen(int maxProgressUpdate, Form formToOpen)
        {
            InitializeComponent();
            //SP.Load();
            //SP.PlayLooping();
            Reset(maxProgressUpdate, formToOpen);
        }

        /// <summary>
        /// Adds a random number to the current value of the LoadingBar until it has reached it's maximum value.
        /// A Delay is added between every update proportional to the progress that is being added.
        /// </summary>
        private async void UpdateProgressBar()
        {
            Random random = new Random();
            int progressToAdd;
            do
            {
                progressToAdd = random.Next(maxProgressUpdate - 2, maxProgressUpdate);
                await Task.Delay(progressToAdd * timeMultiplier);

                try
                {
                    pgrLoadingBar.Value += progressToAdd;
                }
                catch
                {
                    pgrLoadingBar.Value = 100;
                }

            } while (pgrLoadingBar.Value < 100);

            TransitionToNewForm();
        }

        private async void GenerateTaglines()
        { 
            Random random = new Random();
            string tagline;
            do
            {
                tagline = taglines[random.Next(0, taglines.Length)];
                lblTagline.Text = tagline;
                await Task.Delay(3500);
            } while (pgrLoadingBar.Value < 100);
        }

        private void TransitionToNewForm()
        {
            CloseAllOtherForms();
            formToOpen.Visible = false;
            TopMost = true;
            formToOpen.Visible = true;
            isOpening = false;
            tmrSplash.Start();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if (!isOpening)
            {
                Opacity -= transparencyUpdate;

                if (Opacity <= 0)
                {
                    tmrSplash.Stop();
                    formToOpen.Focus();
                    Hide();
                }
            }
            else
            {
                Opacity += transparencyUpdate;

                if(Opacity >= 1)
                {
                    tmrSplash.Stop();
                    UpdateProgressBar();
                }
            }
        }

        private static void CloseAllOtherForms()
        {
            // Iterate through all open forms except the first one
            for (int i = 1; i < Application.OpenForms.Count; i++)
            {
                Form form = Application.OpenForms[i];
                form.Close();
            }
        }

        /// <summary>
        /// Resets the SplashScreen to it's initial state and starts the fading in and out process.
        /// </summary>
        /// <param name="maxProgressUpdate"></param>
        /// <param name="formToOpen"></param>
        public void Reset(int maxProgressUpdate, Form formToOpen)
        {
            this.maxProgressUpdate = maxProgressUpdate;
            this.formToOpen = formToOpen;
            Opacity = 0;
            isOpening = true;
            pgrLoadingBar.Value = 0;
            Show();
            tmrSplash.Start();
            GenerateTaglines();
        }
    }
}
