using System;

namespace ObserverSample.Displays
{
    public class Display1Statistics
    {
        public void Update(float temp, float humidity, float pressure)
        {
            Console.Write("Display pressure update!");
        }

        public void DisplayDate()
        {
            Console.Write("Show some data");
        }
    }
}