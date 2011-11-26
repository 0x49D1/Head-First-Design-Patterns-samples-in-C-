using System;

namespace TemplateMethodSample
{
    class CoffeineBeverage
    {
        public void PrepareReceipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public virtual void AddCondiments()
        {
        }

        public virtual void Brew()
        {
        }

        private void PourInCup()
        {
            Console.WriteLine("Puring into cup");
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }
    }
}
