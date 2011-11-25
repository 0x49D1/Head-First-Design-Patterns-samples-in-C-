using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeSample
{
    interface IPlayer:ISwitch
    {
        void Eject();
        void Pause();
        void Play();
        void Stop();
    }
}
