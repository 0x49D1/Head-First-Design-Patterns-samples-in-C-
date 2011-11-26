using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodSample
{
    class Coffee : CoffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Drippin Coffee through filter");
        }
    }
}
