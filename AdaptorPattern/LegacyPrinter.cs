using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
    public class LegacyPrinter
    {
        public void PrintMessage(string Message)
        {
            Console.WriteLine($"Legacy Print Message :{Message}");
        }
    }
}
