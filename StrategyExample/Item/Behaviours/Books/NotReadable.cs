using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Item.Behaviours
{
    public class NotReadable : IReadable
    {
        public void Read()
        {
            Console.WriteLine("Sorry, i can't read that!");
        }
    }
}
