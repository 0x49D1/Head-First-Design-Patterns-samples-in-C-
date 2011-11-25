using System;

namespace AdapterSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // test!
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(){turkey = turkey};
            Console.WriteLine("The turkey says...");
            turkey.Gobble();
            turkey.Fly();
            Console.WriteLine("The duck says...");
            TestDuck(duck);
            Console.WriteLine("TurkeyAdapter says...");
            TestDuck(turkeyAdapter);

            Console.ReadKey();

        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quarck();
            duck.Fly();
        }
    }
}
