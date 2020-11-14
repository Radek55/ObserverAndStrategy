using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie8
{
    class Thermometer
    {
        public List<Observer> objects;
        public Thermometer()
        {
            objects = new List<Observer>();
        }
        public void Amount(Observer sensor, bool type)
        {
            if(type==true) { objects.Add(sensor); }
            else if(type==false) { objects.Remove(sensor); }
        }
        public void Check()
        {
            Console.WriteLine("There are " + objects.Count + " working thermometers");
        }
        public void CheckTemperature()
        {
            Check();
            Console.WriteLine("\nMonday:");
            foreach (Observer sensors in objects)
            {
                sensors.Received(22.5);
            }
            Console.WriteLine("\nTuesday:");
            foreach (Observer sensors in objects)
            {
                sensors.Received(21.5);
            }
            Console.WriteLine("\nWednesday:");
            foreach (Observer sensors in objects)
            {
                sensors.Received(20.0);
            }
            Console.WriteLine();
        }
    }
}
