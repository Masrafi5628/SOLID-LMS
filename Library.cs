public class Library : IBookOperations
{
    private List<Book> books = new List<Book>();

    public Library() { }

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Added book: {book.Title}");
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
        Console.WriteLine($"Removed book: {book.Title}");
    }
}
