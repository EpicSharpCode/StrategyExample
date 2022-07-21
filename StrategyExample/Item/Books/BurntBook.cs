using StrategyExample.Item.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Item
{
    internal class BurntBook : ItemBase
    {
        public BurntBook()
        {
            name = "Burnt Book";
            selfcost = 0;
            SetReadableBehaviour(new NotReadable());
        }
    }
}
