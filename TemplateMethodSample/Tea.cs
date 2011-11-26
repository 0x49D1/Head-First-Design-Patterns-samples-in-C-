using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodSample
{
    class Tea : CoffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

    }
}
