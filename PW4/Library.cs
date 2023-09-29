using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public override string ToString()
    {
        return $"{Title} by {Author}, Year: {Year}";
    }
}

class LibraryRealization
{
    private List<Book> books;

    public LibraryRealization()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public List<Book> SearchByAuthor(string author)
    {
        return books.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
    }
    public List<Book> SearchByYear(int year)
    {
        return books.Where(book => book.Year == year).ToList();
    }
    public void SortByTitle()
    {
        books = books.OrderBy(book => book.Title).ToList();
    }
    public void SortByAuthor()
    {
        books = books.OrderBy(book => book.Author).ToList();
    }

    public void SortByYear()
    {
        books = books.OrderBy(book => book.Year).ToList();
    }
    public void DisplayBooks()
    {
        Console.WriteLine("Books in the Library:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}

class Library
{
    static void Main()
    {
        LibraryRealization library = new LibraryRealization();
        library.AddBook(new Book { Title = "Book1", Author = "Author1", Year = 2020 });
        library.AddBook(new Book { Title = "Book2", Author = "Author2", Year = 2018 });
        library.AddBook(new Book { Title = "Book3", Author = "Author1", Year = 2019 });

        library.DisplayBooks();
        Console.WriteLine("\nBooks by Author1:");
        List<Book> author1Books = library.SearchByAuthor("Author1");
        foreach (var book in author1Books)
        {
            Console.WriteLine(book);
        }

        library.SortByAuthor();
        Console.WriteLine("\nBooks sorted by Author:");
        library.DisplayBooks();
    }
}