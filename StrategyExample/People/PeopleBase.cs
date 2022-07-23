using StrategyExample.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.People
{
    public abstract class PeopleBase : IPeople
    {
        protected string name;
        protected DateTime birthday;

        protected Inventory inventory;
        protected int inventoryCapacity;

        public PeopleBase() { }

        public void InitInventory()
        {
            inventory = new Inventory(inventoryCapacity);
        }

        public void ShowInfo() => Console.WriteLine($"I am {name}. My birthday is {birthday.ToString("d")}.");
        public Inventory GetInventory() => inventory;
        public string GetName() => name;
    }
}
