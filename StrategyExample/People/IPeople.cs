﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.People
{
    internal interface IPeople
    {
        void ShowInfo();
        Inventory GetInventory();
    }
}
