using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //********* Encapsulation *********************
            //var robot1 = new ChefRobot();
            //robot1.Introduce();
            //robot1.CookFood("Pizza");
            //robot1.Introduce();


            //********** Inherit *************************
            //var robot1 = new ChefRobot();
            //var soupRobot = new SoupChefRobot("Soupy");
            //var grillRobot = new GrillChefRobot();

            //grillRobot.GrillTemperature = 250;

            //grillRobot.Introduce();
            //grillRobot.CookFood("Chicken");
            //grillRobot.GrillSteak();

            //soupRobot.Introduce();
            //soupRobot.MakeSoup();



            //********** Polymorphism *************************
            var soupRobot = new SoupChefRobot("Soupy");
            var grillRobot = new GrillChefRobot("Grilly");

            var myList=new List<ChefRobot>();
            myList.Add(soupRobot);
            myList.Add(grillRobot);

            foreach (var objectList in myList)
            {
                objectList.Introduce();
                objectList.CookSpecialty();
            }


            Console.ReadLine();
        }
    }
}
