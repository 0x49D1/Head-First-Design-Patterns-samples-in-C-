using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverSample.More_Proper;

namespace ObserverSample
{
    class Program
    {
        private static void Main(string[] args)
        {
            // http://www.codeproject.com/Articles/88278/Observer-in-NET-with-IObserver-T
            // http://www.dofactory.com/net/observer-design-pattern
            WeatherData wd = new WeatherData();
            CurrentConditionsDisplay d1 = new CurrentConditionsDisplay(wd);
            StatisticsDisplay d2 = new StatisticsDisplay(wd);
            ForecastDisplay d3 = new ForecastDisplay(wd);

            wd.SetMeasurements(15, 20, 50);
            Console.WriteLine();
            wd.SetMeasurements(25, 10, 10);
            Console.WriteLine();
            wd.SetMeasurements(0, 50, 10);

            Console.ReadKey();
        }
    }
}
