using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IPaymentMethod
    {
        bool ProcessPayment(double amount);
        string GetPaymentDetails();
    }
}
