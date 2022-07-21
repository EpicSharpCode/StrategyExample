using StrategyExample.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample
{
    internal class Program
    {
        public static Inventory inventory = new Inventory(10);

        public static void Main(string[] args)
        {
            inventory.AddItem(new Tomato());
            inventory.items[0].TryEat();

            Console.ReadLine();
        }
    }
}
