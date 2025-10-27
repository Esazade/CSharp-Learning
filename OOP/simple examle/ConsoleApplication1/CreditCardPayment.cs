using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CreditCardPayment : IPaymentMethod
    {
        private string _cardNumber;

        public CreditCardPayment(string cardNumber)
        {
            _cardNumber = cardNumber;
        }

        public bool ProcessPayment(double amount)
        {
            Console.WriteLine("payment with credit card");
            return true;
        }

        public string GetPaymentDetails()
        {
            return _cardNumber.ToString();
        }
    }
}
