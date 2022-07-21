using StrategyExample.Item.Behaviours;
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

        IEatable eatableBehaviour;
        IReadable readableBehaviour;

        public ItemBase() 
        {
            SetEatableBehaviour(new NotEatable());
            SetReadableBehaviour(new NotReadable());
        }

        public ItemBase(string _name, float _selfcost) : base()
        {
            name = _name;
            selfcost = _selfcost;
        }

        public void SetEatableBehaviour(IEatable ieatable) => eatableBehaviour = ieatable;
        public void SetReadableBehaviour(IReadable ireadable) => readableBehaviour = ireadable;
        public void TryEat() { Console.WriteLine($"I try to eat \"{name}\""); eatableBehaviour.Eat(); }
        public void TryRead() { Console.WriteLine($"I try to read \"{name}\""); readableBehaviour.Read(); }
        public void Examine() {
            string eatableState = eatableBehaviour.GetType().Equals(new Eatable().GetType()) ? "eatable" : "not eatable";
            Console.WriteLine($"It's seems to be \"{name}\", it's selfcost is {selfcost} and it's {eatableState}"); }

    }
}
