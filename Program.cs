class Program
{
    static void Main()
    {
        Library library = new Library();
        LibraryManagementSystem system = new LibraryManagementSystem(library);

        Book book1 = new Book("C# Intoduction", "Author1", "12345");
        Book book2 = new Book("SOLID Principles", "Author2", "67890");

        system.AddNewBook(book1);
        system.AddNewBook(book2);

        Member member = new Member("Abdullah");
        member.BorrowBook(book1);
        member.ReturnBook(book1);
        member.ReturnBook(book2);
    }
}