using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample
{
    class DiscountCalculator
    {
        public double CalculateDiscount(IDiscountStrategy discount, double amount)
        {
            return discount.ApplyDiscount(amount);
        }
    }
}
