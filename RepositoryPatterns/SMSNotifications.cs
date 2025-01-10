using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class SMSNotifications : INotification
    {
        public void NotifyMessage(string Message)
        {
           Console.WriteLine($"SMS Notification:{ Message}");
        }
    }

    public class EmailNotification : INotification
    {
        public void NotifyMessage(string Message)
        {
            Console.WriteLine($"Email Notification:{Message}");
        }
    }

    public class PushNotifications : INotification
    {
        public void NotifyMessage(string Message)
        {
            Console.WriteLine($"Push Notification:{Message}");
        }
    }


}
