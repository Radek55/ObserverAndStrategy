using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie8
{
    interface ITruck
    {
        int Load { get; set; }
        int FuelUse { get; set; }
        int Cost(int distance, int cargo);
    }
}
