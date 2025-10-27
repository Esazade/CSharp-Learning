using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CashPayment:IPaymentMethod
    {
        public bool ProcessPayment(double amount)
        {
            Console.WriteLine("cash payment");
            return true;
        }

        public string GetPaymentDetails()
        {
            return "cash payment";
        }     
    }
}
