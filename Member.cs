public class Member : IUser
{
    public string Name { get; set; }
    private List<Book> borrowedBooks = new List<Book>();

    public Member(string name)
    {
        Name = name;
    }

    public void BorrowBook(Book book)
    {
        if (book.IsAvailable)
        {
            borrowedBooks.Add(book);
            book.IsAvailable = false;
            Console.WriteLine($"{Name} borrowed {book.Title}");
        }
        else
        {
            Console.WriteLine($"{book.Title} is not available.");
        }
    }

    public void ReturnBook(Book book)
    {
        if (borrowedBooks.Contains(book))
        {
            borrowedBooks.Remove(book);
            book.IsAvailable = true;
            Console.WriteLine($"{Name} returned {book.Title}");
        }
        else
        {
            Console.WriteLine($"{Name} did not borrow {book.Title}");
        }
    }
}