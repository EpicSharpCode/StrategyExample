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
            characters.Add(new ManLeo());
            var man = characters.Last();
            OutputEmptyLine();
            man.GetInventory().AddItem(new Tomato());
            man.GetInventory().items.Last().Examine();
            man.GetInventory().items.Last().TryEat();
            man.GetInventory().items.Last().TryRead();
            OutputEmptyLine();
            man.GetInventory().AddItem(new RottenApple());
            man.GetInventory().items.Last().Examine();
            man.GetInventory().items.Last().TryEat();
            man.GetInventory().items.Last().TryRead();
            OutputEmptyLine();
            man.GetInventory().AddItem(new BurntBook());
            man.GetInventory().items.Last().Examine();
            man.GetInventory().items.Last().TryEat();
            man.GetInventory().items.Last().TryRead();
            OutputEmptyLine();
            man.GetInventory().AddItem(new TheWhaleBook());
            man.GetInventory().items.Last().Examine();
            man.GetInventory().items.Last().TryEat();
            man.GetInventory().items.Last().TryRead();
            OutputEmptyLine();
            man.GetInventory().AddItem(new EatableBook());
            man.GetInventory().items.Last().Examine();
            man.GetInventory().items.Last().TryEat();
            man.GetInventory().items.Last().TryRead();

            Console.ReadLine();
        }

        public static void OutputEmptyLine() => Console.WriteLine();
    }
}
