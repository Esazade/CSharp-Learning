using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class GrillChefRobot:ChefRobot
    {
        private int _grillTemperature;

        public int GrillTemperature
        {
            get { return _grillTemperature; }
            set
            {
                if (value < 0) _grillTemperature = 0;
                else if (value > 300) _grillTemperature = 300;
                else _grillTemperature = value;
            }
        }

        public GrillChefRobot(string name):base(name)
        {
            GrillTemperature = 250; 
        }

        public void GrillSteak()
        {
            if (GrillTemperature > 200 && BatteryLevel > 20)
            {
                Console.WriteLine(Name+" is grilling a juicy steak! ");
                BatteryLevel -= 20;
            }
            else
            {
                Console.WriteLine(Name + " can't grill. Check temperature (" + GrillTemperature + "°) and battery ({"+BatteryLevel+"}%)!");
            }
        }

        public override void CookSpecialty()
        {
            if (GrillTemperature > 220)
            {
                Console.WriteLine("I'm grilling my special ribeye steak!");
                BatteryLevel -= 25;
            }
            else
            {
                Console.WriteLine(Name + " can't grill. Check temperature (" + GrillTemperature + "°) and battery ({" + BatteryLevel + "}%)!");
            }
        }

    }
}
