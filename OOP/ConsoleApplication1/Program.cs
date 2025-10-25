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
            var robot1 = new ChefRobot();
            robot1.Introduce();
            robot1.CookFood("Pizza");
            robot1.Introduce();

            Console.ReadLine();
        }
    }
}
