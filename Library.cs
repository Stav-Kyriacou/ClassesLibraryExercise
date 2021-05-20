using System;
using System.Collections.Generic;

namespace ClassesExercise
{
    public class Library
    {
        public string name;
        public string location;
        public List<Book> books;

        public Library (string name, string location, List<Book> books)
        {
            this.name = name;
            this.location = location;
            this.books = books;
        }
        
        public void AddBookToCollection(Book newBook)
        {
            books.Add(newBook);
        }
        public void PrintBookTitles()
        {
            foreach (Book b in books)
            {
                Console.WriteLine(b.title);
            }
        }
    }
}