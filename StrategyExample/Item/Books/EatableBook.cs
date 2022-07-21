using StrategyExample.Item.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Item
{
    internal class EatableBook : ItemBase
    {
        public EatableBook()
        {
            name = "Eatable Book";
            selfcost = 3;
            SetEatableBehaviour(new Eatable());
            SetReadableBehaviour(new Readable());
        }
    }
}
