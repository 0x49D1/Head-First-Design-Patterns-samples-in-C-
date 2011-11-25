using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeSample
{
    class Amplifier : ISwitch
    {
        public Tuner tuner;
        public DVDPlayer dvdPlayer;
        public CDPlayer cdPlayer;

        public void On()
        {
            Console.WriteLine("Amplifier is ON");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier is OFF");
        }

        public void SetCD(string cd)
        {

        }

        public void SetDVD(string dvd)
        {
        }

        public void SetStereoSound()
        {
        }

        public void SetSurroundSound()
        {
        }

        public void SetTuner()
        {
        }

        public void SetVolume(int volumeLevel)
        {
            Console.WriteLine("Volume was set on {0}", volumeLevel);
        }

    }
}
