using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie8
{
    class Observer
    {
        public string Place { get; set; }
        public double OptimalTemperature { get; set; }

        public Observer(string _place, double _optimaltemp)
        {
            Place = _place;
            OptimalTemperature = _optimaltemp;
        }
        public void Received(double temp)
        {
            if (temp > OptimalTemperature)
            {
                double difference = temp - OptimalTemperature;
                Console.WriteLine("Temperature in "+Place+" is "+difference+" degrees above optimal.");
            }
            else if (temp < OptimalTemperature)
            {
                double difference = OptimalTemperature - temp;
                Console.WriteLine("Temperature in " + Place + " is " + difference + " degrees under optimal.");
            }
            else if (temp==OptimalTemperature)
            {
                Console.WriteLine("Temperature in " + Place + " is optimal.");
            }
        }
    }
}
