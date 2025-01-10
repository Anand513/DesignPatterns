using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecratorPattern
{
    public class SMSNotification : NotificationDecrotor
    {
        public SMSNotification(INotification notification) : base(notification)
        {
        }

        public override void send(string message)
        {
            base.send(message);
            Console.WriteLine($"SMS :{ message}");
        }
    }

    public class PushNotification : NotificationDecrotor
    {
        public PushNotification(INotification notification) : base(notification)
        {
        }

        public override void send(string message)
        {
          //  base.send(message);
            Console.WriteLine($"Push :{message}");
        }
    }
}
