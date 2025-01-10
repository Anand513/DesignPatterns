using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratoryPatterns 
{
    public class BookIteretor :IIterator<Book>
    {
        private readonly List<Book> _books;
        private int position = 0;

        public BookIteretor(List<Book> books)
        {
           _books = books;
        }

        public bool HasNext()
        {
           return position < _books.Count;
        }

        public Book Next()
        {
           if(!HasNext())
            {
                throw new InvalidOperationException("No More Books");
            }
           return _books[position++];
        }
    }
}
