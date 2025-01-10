using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratoryPatterns
{
    public interface IBookCollections
    {
        IIterator<Book> CreateIterotor();
    }
}
