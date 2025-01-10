using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DecratorPattern
{
    public class NotificationDecrotor : INotification
    {
        private INotification _notification;


        public NotificationDecrotor(INotification notification)
        {
            _notification = notification;

        }

        public virtual void send(string message)
        {
            _notification.send(message);
        }
    }
}
