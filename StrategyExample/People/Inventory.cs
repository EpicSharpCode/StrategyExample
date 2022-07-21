using StrategyExample.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.People
{
    public class Inventory
    {
        public float capacity { get; private set; }
        public List<ItemBase> items { get; private set; }

        public Inventory(float _capacity)
        {
            capacity = _capacity;
            items = new List<ItemBase>();
            Console.WriteLine($"Now i have inventory with {capacity} capacity!");
        }

        public void AddItem(ItemBase item) 
        {
            if (items.Count + 1 < capacity)
            {
                items.Add(item);
                Console.WriteLine($"I take \"{item.name}\" in my inventory");
            }
            else
            {
                Console.WriteLine($"Sorry, i can't take \"{item.name}\" in my inventory");
            }
        }
    }
}
