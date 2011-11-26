using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodSample
{
    class Tea
    {
        public void PrepareReceipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        private void AddLemon()
        {
            Console.WriteLine("Adding lemon");
        }

        private void PourInCup()
        {
            Console.WriteLine("Puring into cup");
        }

        private void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }
    }
}
