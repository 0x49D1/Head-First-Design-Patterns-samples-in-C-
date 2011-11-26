using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodSample
{
    class Coffee
    {
        public void PrepareReceipe()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        private void AddSugarAndMilk()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        private void PourInCup()
        {
            Console.WriteLine("Puring into cup");
        }

        private void BrewCoffeeGrinds()
        {
            Console.WriteLine("Drippin Coffee through filter");
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }
    }
}
