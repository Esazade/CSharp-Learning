using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample
{
    class PercentageDiscount:IDiscountStrategy
    {
        public double ApplyDiscount(double amount)
        {
            return amount * 0.9;
        }
    }
}
