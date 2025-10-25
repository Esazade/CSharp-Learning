using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SoupChefRobot:ChefRobot
    {
        public SoupChefRobot(string name) : base() { }

        public void MakeSoup()
        {
            if (BatteryLevel > 10)
            {
                Console.WriteLine(Name+" is preparing delicious soup!");
                BatteryLevel -= 10;
            }
            else
            {
                Console.WriteLine(Name+" can't make soup. Not enough battery!");
            }
        }
    }
}
