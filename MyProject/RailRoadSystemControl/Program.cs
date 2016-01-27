using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainControlSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //play sound
            //SoundPlayer simpleSound = new SoundPlayer(@"..\..\Resources\railwayStationSound.wav");
            //simpleSound.Play();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormHome());
        }
    }
}
