using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class calculator
    {
        public int Calculator(int num1, int num2, string operation)
        {
            if (operation == "/")
            {
                return Divide(num1, num2);
            }
            else
            {
                throw new ArgumentOutOfRangeException("The matematical operator is not supported");
            }
        }

        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}
