using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverSample.Displays
{
    public class Display1Conditions
    {
        public void Update(float temp, float humidity, float pressure)
        {
            Console.Write("Display conditions update!");
        }
    }
}
