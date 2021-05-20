using System;

namespace ClassesExercise
{
    public class Book
    {
        public string title;
        public int ISBN;
        public int pages;
        public Author author;
        public bool isBorrowed;

        public Book (string title, int ISBN, int pages, Author author, bool isBorrowed)
        {
            this.title = title;
            this.ISBN = ISBN;
            this.pages = pages;
            this.author = author;
            this.isBorrowed = isBorrowed;
        }

        public void Borrow()
        {
            if (!isBorrowed)
            {
                isBorrowed = true;
                Console.WriteLine("You borrowed the book: {0}, enjoy!", title);
            }
            else
            {
                Console.WriteLine("The book: {0} has already been borrowed, sorry!", title);
            }
        }
        public void Return()
        {
            if (isBorrowed)
            {
                isBorrowed = false;
                Console.WriteLine("Thank you for returning the book: {0}", title);
            }
            else
            {
                Console.WriteLine("The book: {0} has already been returned!", title);
            }
        }
    }
}