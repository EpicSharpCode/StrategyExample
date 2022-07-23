using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.People
{
    internal class ManLeo : PeopleBase
    {
        public ManLeo()
        {
            name = "Leo";
            birthday = new DateTime(1997, 10, 15);
            inventoryCapacity = 10;

            InitInventory();
            ShowInfo();
        }
    }
}
