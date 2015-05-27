    using System;

namespace ObserverSample.More_Proper
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = temp;
            this.pressure = temp;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Statistics for {0}: temperature {1}C, humidity {2}%, pressure {3}",DateTime.Now, temperature, humidity, pressure);
        }
    }
}