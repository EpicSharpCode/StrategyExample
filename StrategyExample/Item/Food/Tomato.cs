using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Item
{
    public class Tomato : ItemBase
    {
        public Tomato()
        {
            name = "Tomato";
            selfcost = 1;
            SetEatableBehaviour(new Eatable());
        }
    }
}
