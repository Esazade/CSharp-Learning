using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation");
            string operation = Console.ReadLine().ToUpperInvariant();

            try
            {
                var calculator = new calculator();
                int result = calculator.Calculator(number1, number2, operation);
                Console.WriteLine("Output is : " + result);
            }
            catch(ArgumentNullException ex){
                Console.WriteLine("operation was not provided. " + ex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("the value out of range. " + ex);
            }
            catch(Exception ex){
                Console.WriteLine("Sorry,something went wrong" + ex);
            }

            

            Console.ReadLine();
        }
    }
}
