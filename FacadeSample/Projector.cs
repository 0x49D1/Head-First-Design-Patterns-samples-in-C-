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
            throw new NotImplementedException();
        }

        public void Off()
        {
            throw new NotImplementedException();
        }

        public void TVMode()
        {
        }

        public void WideScreenMode()
        {
        }
    }
}
