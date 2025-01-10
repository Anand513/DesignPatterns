using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecratorPattern
{
    public class EmailNotification : INotification
    {
        public void send(string message)
        {
            Console.WriteLine($"Email :{message}");
        }
    }
}
