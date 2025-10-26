using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    class PushNotification:INotification
    {
        private string _deviceId;

        public PushNotification(string deviceId)
        {
            _deviceId = deviceId;
        }

        public void Send(string message)
        {
            Console.WriteLine("Push notification sent to device " + _deviceId + ": " + message);
        }

        public string Status
        {
            get { return "Push Delivered"; }
        }

    }
}
