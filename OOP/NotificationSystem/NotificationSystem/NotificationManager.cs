using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    class NotificationManager
    {
        List<INotification> _notifications = new List<INotification>();

        public void AddNotification(INotification notification)
        {
            _notifications.Add(notification);
        }

        public void SendAll(string message){
            foreach (var _perNotification in _notifications)
            {
                _perNotification.Send(message);
            }
        }

        public void PrintStatusReport()
        {
            foreach (var _perNotification in _notifications)
            {
                Console.WriteLine("Status: " + _perNotification.Status);
            }
        }
    }
}
