using IteratoryPatterns;
BookCollections books=new BookCollections();
books.AddBook(new Book("DesignPatterns"));
books.AddBook(new Book("Client Code"));
books.AddBook(new Book("Client Code 1"));

IIterator<Book> iterator = books.CreateIterotor();

while(iterator.HasNext())
{
    Console.WriteLine(iterator.Next().Title);
}