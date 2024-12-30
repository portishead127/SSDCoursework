using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework.Forms
{
    public partial class SplashScreen : Form
    {
        const int maxProgressUpdate = 3;
        const double transparencyUpdate = 0.05;
        const int timeMultiplier = 20;
        public SplashScreen()
        {
            InitializeComponent();
            UpdateProgressBar();
        }

        /// <summary>
        /// Adds a random number to the current value of the LoadingBar until it has reached it's maximum value.
        /// A Delay is added between every update proportional to the progress that is being added.
        /// </summary>
        async void UpdateProgressBar()
        {
            Random random = new Random();
            int progressToAdd;
            do
            {
                await Task.Delay(maxProgressUpdate * timeMultiplier);

                progressToAdd = random.Next(0, maxProgressUpdate);
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

        void TransitionToNewForm()
        {
            RegistryHolder registryHolder = new RegistryHolder();
            registryHolder.Visible = false;

            TopMost = true;

            registryHolder.Visible = true;
            tmrSplash.Start();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            Opacity -= transparencyUpdate;

            if(Opacity <= 0)
            {
                tmrSplash.Stop();
                Hide();
            }
        }
    }
}
