using System;

namespace ObserverSample.Displays
{
    public class Display1Forecast
    {
        public void Update(float temp, float humidity, float pressure)
        {
            Console.Write("Display forecast update!");
        }
    }
}