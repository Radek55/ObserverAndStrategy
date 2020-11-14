using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie8
{
    class BigTruck : ITruck
    {
        public int Load { get; set; }
        public int FuelUse { get; set; }
        public BigTruck()
        {
            Load = 100;
            FuelUse = 50;
        }
        public int Cost(int distance, int cargo)
        {
            return cargo / Load * distance * FuelUse;
        }
    }
}
