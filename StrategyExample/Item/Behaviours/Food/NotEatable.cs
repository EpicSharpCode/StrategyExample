﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Item
{
    public class NotEatable : IEatable
    {
        public void Eat()
        {
            Console.WriteLine("I can't eat that...");
        }
    }
}
