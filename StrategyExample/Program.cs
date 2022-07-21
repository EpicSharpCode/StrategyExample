using StrategyExample.Item;
using StrategyExample.People;
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
            var man = characters.Last();
            OutputEmptyLine();
            man.inventory.AddItem(new Tomato());
            man.inventory.items.Last().Examine();
            man.inventory.items.Last().TryEat();
            man.inventory.items.Last().TryRead();
            OutputEmptyLine();
            man.inventory.AddItem(new RottenApple());
            man.inventory.items.Last().Examine();
            man.inventory.items.Last().TryEat();
            man.inventory.items.Last().TryRead();
            OutputEmptyLine();
            man.inventory.AddItem(new BurntBook());
            man.inventory.items.Last().Examine();
            man.inventory.items.Last().TryEat();
            man.inventory.items.Last().TryRead();
            OutputEmptyLine();
            man.inventory.AddItem(new TheWhaleBook());
            man.inventory.items.Last().Examine();
            man.inventory.items.Last().TryEat();
            man.inventory.items.Last().TryRead();
            OutputEmptyLine();
            man.inventory.AddItem(new EatableBook());
            man.inventory.items.Last().Examine();
            man.inventory.items.Last().TryEat();
            man.inventory.items.Last().TryRead();

            Console.ReadLine();
        }

        public static void OutputEmptyLine() => Console.WriteLine();
    }
}
