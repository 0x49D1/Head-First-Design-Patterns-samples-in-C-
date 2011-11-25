using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterSample
{
    class WildTurkey:ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying short distance :S");
        }
    }
}
