using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeSample
{
    class Amplifier:ISwitch
    {
        public Tuner tuner;
        public DVDPlayer dvdPlayer;
        public CDPlayer cdPlayer;

        public void On()
        {
            throw new NotImplementedException();
        }

        public void Off()
        {
            throw new NotImplementedException();
        }

        public void SetCD()
        {
        }

        public void SetDVD()
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

        public void SetVolume()
        {
        }

    }
}
