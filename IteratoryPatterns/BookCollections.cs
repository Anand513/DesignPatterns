using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratoryPatterns
{
    public class BookCollections : IBookCollections
    {
        private readonly List<Book> books=new List<Book> ();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

       public  IIterator<Book> CreateIterotor()
        {
          return new BookIteretor(books);
        }
    }
}
