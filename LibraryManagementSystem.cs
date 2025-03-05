public class LibraryManagementSystem
{
    private readonly IBookOperations _library;

    public LibraryManagementSystem(IBookOperations library)
    {
        _library = library;
    }

    public void AddNewBook(Book book)
    {
        _library.AddBook(book);
    }
}
