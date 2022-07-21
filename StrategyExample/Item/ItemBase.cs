using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Item
{
    public class ItemBase
    {
        public string name { get; set; }
        public float selfcost { get; set; }

        public IEatable eatableBehaviour { get; private set; }

        public ItemBase() { }

        public ItemBase(string _name, float _selfcost)
        {
            name = _name;
            selfcost = _selfcost;

            SetEatableBehaviour(new NotEatable());
        }

        public void SetEatableBehaviour(IEatable ieatable) => eatableBehaviour = ieatable;
        public void TryEat() => eatableBehaviour.Eat();

    }
}
