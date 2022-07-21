using StrategyExample.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample
{
    public class PeopleBase
    {
        public string name { get; private set; }
        public DateTime birthday { get; private set; }

        public Inventory inventory;

        public PeopleBase(string _name, DateTime _birthday, int _inventoryCapacity)
        {
            name = _name;
            birthday = _birthday;
            Console.WriteLine($"I am {name}. My birthday {birthday.ToString("d")}");

            inventory = new Inventory(_inventoryCapacity);
        }
    }
}
