using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Libary
{
    public class Book
    {
        string Title;
        string Author;
        string ISBN;

        // Example of a constructor that allows us to 'construct' a new
        // Book object
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        public void DisplayInfo()   // tutorial has just "void DisplayInfo()" – needs public to be called from Program.cs
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}

// The constructor will also remove the need to make the properties Title, Author and ISBN public.




// Note: Now we can quickly add a new book object by calling the book constructor within the Book class. Remember,
// we must ensure that the constructor name is the same as the class name, otherwise your constructor will not work.


