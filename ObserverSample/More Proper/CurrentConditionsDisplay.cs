using System;

namespace ObserverSample.More_Proper
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        /// <summary>
        /// Save the temperature and humidity data and display the message
        /// </summary>
        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = temp;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions are: temperature {0}C, humidity {1}%", temperature, humidity);
        }
    }
}