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
        public static List<PeopleBase> characters = new List<PeopleBase>();

        public static void Main(string[] args)
        {
            characters.Add(new PeopleBase("Leo", new DateTime(1997, 10, 15), 10));
            var man = characters[0];

            man.inventory.AddItem(new Tomato());
            man.inventory.items[0].Examine();
            man.inventory.items[0].TryEat();
            man.inventory.AddItem(new RottenApple());
            man.inventory.items[1].Examine();
            man.inventory.items[1].TryEat();

            Console.ReadLine();
        }
    }
}
