using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    class EmailNotification:INotification
    {
        private string _emailAddress;

        public EmailNotification(string email){
            _emailAddress = email;
        }

        public void Send(string message)
        {
            Console.WriteLine("Email sent to " + _emailAddress + " : " + message);
        }

        public string Status
        {
            get { return "Email Delivered"; }
        }

    }
}
