using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Item.Behaviours
{
    internal class Readable : IReadable
    {
        public void Read()
        {
            Console.WriteLine("I am read this book");
        }
    }
}
