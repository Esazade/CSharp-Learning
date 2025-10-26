using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    class SMSNotification:INotification
    {
        private string _phoneNumber;

        public SMSNotification(string phone)
        {
            _phoneNumber = phone;
        }

        public void Send(string message)
        {
            Console.WriteLine("SMS sent to " + _phoneNumber + " : " + message);
        }

        public string Status
        {
            get { return "SMS Sent"; }
        }

    }
}
