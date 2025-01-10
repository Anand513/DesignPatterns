using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
    public class AdapterPrinter : IPrinter
    {
        private readonly LegacyPrinter _legacyPrinter;

        public AdapterPrinter(LegacyPrinter legacyPrinter)
        {
            _legacyPrinter = legacyPrinter;
        }


        public void Print(string text)
        {
            _legacyPrinter.PrintMessage(text);
        }
    }
}
