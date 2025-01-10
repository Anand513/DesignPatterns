using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecratorPattern
{
    public interface INotification
    {
        void send(string message);
    }
}
