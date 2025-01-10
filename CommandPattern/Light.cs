using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is Turn on");
        }

        public void Turnoff() 
        { 
            Console.WriteLine("Light is Turn oFF"); 
        }
    }
}
