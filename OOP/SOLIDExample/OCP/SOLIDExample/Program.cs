using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new DiscountCalculator();
            var amount = 100.0;

            Console.WriteLine("Fixed:"+ calculator.CalculateDiscount(new FixedDiscount(), amount));
            Console.WriteLine("Percentage: "+calculator.CalculateDiscount(new PercentageDiscount(), amount));
            Console.WriteLine("Seasonal: " + calculator.CalculateDiscount(new Seasonal(), amount));

            Console.ReadLine();
        }
    }
}
