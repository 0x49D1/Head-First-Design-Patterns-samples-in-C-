using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverSample.Displays;

namespace ObserverSample
{
    public class WrongWeatherData
    {

        public Display1Forecast forecastDisplay { get; set; }
        public Display1Statistics statisticsDisplay { get; set; }
        public Display1Conditions conditionsDisplay { get; set; }

        public float GetTemperature()
        {
            // Some implementation
            return 42;
        }

        public float GetHumidity()
        {
            return 20;
        }

        public float GetPressure()
        {
            return 18;
        }

        public void MeasuremetChanged()
        {
            float temp = GetTemperature();
            float humidity = GetHumidity();
            float pressure = GetPressure();

            // update the displays
            conditionsDisplay.Update(temp, humidity, pressure);
            statisticsDisplay.Update(temp, humidity, pressure);
            forecastDisplay.Update(temp, humidity, pressure);
        }


        #region Whats wrong?

        // By coding to concrete implementations we have no way to add or remove other display types without making changes to the program
        // All the display elements have Update() method with same parameters, so thats a hint to extracting the interface

        #endregion


    }

}
