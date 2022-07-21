using StrategyExample.Item.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Item
{
    internal class TheWhaleBook : ItemBase
    {
        public TheWhaleBook()
        {
            name = "Book: The Whale";
            selfcost = 5;
            SetReadableBehaviour(new Readable());
        }
    }
}
