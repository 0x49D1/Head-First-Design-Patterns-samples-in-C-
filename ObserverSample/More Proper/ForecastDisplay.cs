using System;

namespace ObserverSample.More_Proper
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;

        public ForecastDisplay(ISubject weatherData)
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
            Console.WriteLine(temperature > 20 ? "{0} Its warm outside!" : "{0} Probably its cooold!!", DateTime.Now);
        }
    }
}