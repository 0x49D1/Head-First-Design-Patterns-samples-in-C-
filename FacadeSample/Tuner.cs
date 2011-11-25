using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeSample
{
    class Tuner:ISwitch
    {
        public void On()
        {
            Console.WriteLine("Tuner is ON");
        }

        public void Off()
        {
            Console.WriteLine("Tuner is OFF");
        }

        public void SetAm()
        {
        }

        public void SetFm()
        {
        }

        public void SetFrequency()
        {
        }

    }
}
