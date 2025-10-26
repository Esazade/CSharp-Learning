using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    interface INotification
    {
        string Status { get; }
        void Send(string message);
    }
}
