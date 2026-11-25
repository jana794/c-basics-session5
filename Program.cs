using System;

enum Genre
{
    Fiction,
    NonFiction,
    Science
}

class Book
{
    private string password = "secret";

    internal int copiesInStock = 5;

    public string Title;

    public Genre Genre { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();

        Console.WriteLine("Question 1");
        Console.WriteLine("Cannot access password because it is private.");

        Console.WriteLine("Question 2");
        Console.WriteLine(book.copiesInStock);

        Console.WriteLine("Question 3");
        book.Title = "C# Programming";
        Console.WriteLine(book.Title);

        Console.WriteLine("Question 4");
        book.Genre = Genre.Science;
        Console.WriteLine(book.Genre);

        Console.WriteLine("Question 5");
        Console.WriteLine((int)Genre.Fiction);
        Console.WriteLine((int)Genre.NonFiction);
        Console.WriteLine((int)Genre.Science);

        Console.WriteLine("Question 6");
        int genreNumber = 1;
        Genre genre = (Genre)genreNumber;
        Console.WriteLine(genre);

        Console.WriteLine("Question 7");
        Genre genre2 = Genre.Fiction;
        string genreString = genre2.ToString();
        Console.WriteLine(genreString);

        Console.WriteLine("Question 8");
        string genreText = "Science";
        Genre genre3 = (Genre)Enum.Parse(typeof(Genre), genreText);
        Console.WriteLine(genre3);

        Console.WriteLine("Question 9");
        string genreText2 = "Mystery";

        if (Enum.TryParse(genreText2, out Genre result))
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Unknown genre");
        }
    }
}
