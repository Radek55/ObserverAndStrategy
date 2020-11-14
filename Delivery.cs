using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie8
{
    class Delivery
    {
        public ITruck truckType { get; set; }
        public Delivery() { }
        public void SetTruck(ITruck truck)
        {
            truckType = truck;
        }
        public void Go()
        {
            Console.WriteLine("Delivery will cost " + truckType.Cost(20,200)+" $");
        }
    }
}
