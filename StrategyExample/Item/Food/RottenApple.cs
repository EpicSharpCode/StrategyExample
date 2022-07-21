using StrategyExample.Item.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Item
{
    internal class RottenApple : ItemBase
    {
        public RottenApple()
        {
            name = "Rotten Apple";
            selfcost = 0;
            SetEatableBehaviour(new NotEatable());
        }
    }
}
