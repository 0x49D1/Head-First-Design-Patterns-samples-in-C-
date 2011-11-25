using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeSample
{
    class Projector:ISwitch
    {
        public DVDPlayer dvdPlayer;

        public Projector(DVDPlayer player)
        {
            dvdPlayer = player;
        }

        public void On()
        {
            Console.WriteLine("Porjector is ON");
        }

        public void Off()
        {
            Console.WriteLine("Projector is OFF");
        }

        public void TVMode()
        {
            Console.WriteLine("TVMode is on");
        }

        public void WideScreenMode()
        {
            Console.Write("Wide screen mode is ON");
        }
    }
}
