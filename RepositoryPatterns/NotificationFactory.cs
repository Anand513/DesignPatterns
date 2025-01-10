using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class NotificationFactory
    {

        public static INotification CreateNotification(string Type)
        {


            return Type.ToLower() switch
            {
                "email" => new EmailNotification(),
                "sms"=>new SMSNotifications(),
                "push"=>new PushNotifications(),
                _=>throw new ArgumentException("Invalid operations"),

            };
        }
    }
}
