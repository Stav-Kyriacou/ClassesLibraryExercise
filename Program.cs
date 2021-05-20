using System;
using System.Collections.Generic;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Author stavros = new Author("Stavros", "Kyriacou");
            Author someone = new Author("Someone", "Somebody");

            List<Book> books = new List<Book>();

            books.Add(new Book("idk", 1234, 2000, stavros, false));
            books.Add(new Book("yes", 4567, 2001, stavros, false));
            books.Add(new Book("nope", 8901, 1999, stavros, false));
            books.Add(new Book("ahahaha", 1111, 500, someone, false));
            books.Add(new Book("<(O_O)>", 2222, 600, someone, false));


            Library library = new Library("Big Library", "Earth?", books);

            Book b1 = new Book("this is a book title", 1111, 321093210, stavros, false);


            library.AddBookToCollection(b1);

            library.PrintBookTitles();

            library.books[0].Borrow();
            library.books[1].Borrow();

            library.books[0].Return();
            library.books[1].Return();
        }
    }
}
