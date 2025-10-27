using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample
{
    interface IDiscountStrategy
    {
        double ApplyDiscount(double amount);
    }
}
