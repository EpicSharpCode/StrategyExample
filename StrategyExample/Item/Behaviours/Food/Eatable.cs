using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Item
{
    internal class Eatable : IEatable
    {
        public void Eat()
        {
            Console.WriteLine("Nom nom nom, very tasty!");
        }
    }
}
