using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeSample
{
    class CDPlayer:IPlayer
    {
        public void On()
        {
            Console.WriteLine("CD Player is ON");
        }

        public void Off()
        {
            Console.WriteLine("CD Player is OFF");
        }

        public void Eject()
        {
        }

        public void Pause()
        {
        }

        public void Play()
        {
        }

        public void Stop()
        {
        }
    }
}
