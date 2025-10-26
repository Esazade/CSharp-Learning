using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var _managerNotification = new NotificationManager();

            _managerNotification.AddNotification(new EmailNotification("test@google.com"));
            _managerNotification.AddNotification(new SMSNotification("123456789"));
            _managerNotification.AddNotification(new PushNotification("123"));

            Console.WriteLine("=== Sending Messages ===");
            _managerNotification.SendAll("The public message");

            Console.WriteLine("\n=== Status Report ===");
            _managerNotification.PrintStatusReport();

            Console.ReadLine();
        }
    }
}
