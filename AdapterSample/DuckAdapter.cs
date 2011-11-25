using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterSample
{
    class DuckAdapter:ITurkey
    {
        public IDuck duck;

        public DuckAdapter(IDuck d)
        {
            duck = d;
        }

        public void Gobble()
        {
            duck.Quarck();
        }

        public void Fly()
        {
            duck.Fly();
        }
    }
}
