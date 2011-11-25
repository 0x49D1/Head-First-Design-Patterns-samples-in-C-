using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterSample
{
    class MallardDuck : IDuck
    {
        public void Quarck()
        {
            Console.WriteLine("Quack");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
