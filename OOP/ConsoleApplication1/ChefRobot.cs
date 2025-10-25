using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //Encapsulation
    class ChefRobot
    {
        private string name;
        private int batteryLevel;

        public string Name
        {
            get { return name; }
        }

        public int BatteryLevel
        {
            get { return batteryLevel; }
            set
            {
                if (value < 0) batteryLevel = 0;
                else if (value > 100) batteryLevel = 100;
                else batteryLevel = value;
            }
        }

        public ChefRobot()
        {
            name = "Test";
            batteryLevel = 100;
        }
        public void Introduce()
        {
            Console.WriteLine("Hello, I am " + Name + " and I have " + batteryLevel.ToString() + "% battery remaining.");
        }

        public void CookFood(string foodName)
        {
            Console.WriteLine(Name + " is cooking " + foodName + " for you! Nom nom.");
            BatteryLevel -= 10;
        }
    }
}
