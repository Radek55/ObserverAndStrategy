using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie8
{
    class SmallTruck : ITruck
    {
        public int Load { get; set; }
        public int FuelUse { get; set; }
        public SmallTruck()
        {
            Load = 50;
            FuelUse = 20;
        }
        public int Cost(int distance, int cargo)
        {
            return cargo / Load * distance * FuelUse;
        }
    }
}
