using IteratoryPatterns;
BookCollections books=new BookCollections();
books.AddBook(new Book("DesignPatterns"));
books.AddBook(new Book("Client Code"));


IIterator<Book> iterator = books.CreateIterotor();

while(iterator.HasNext())
{
    Console.WriteLine(iterator.Next().Title);
}