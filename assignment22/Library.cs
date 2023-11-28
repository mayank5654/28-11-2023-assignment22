using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment22
{
    internal class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully!");
        }

        public void ViewAllBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void SearchBookById(int bookId)
        {
            Book foundBook = books.Find(book => book.BookId == bookId);

            if (foundBook != null)
            {
                Console.WriteLine("Book found:");
                Console.WriteLine(foundBook);
            }
            else
            {
                Console.WriteLine("Book not found!");
            }
        }

        public void SearchBookByTitle(string title)
        {
            Book foundBook = books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (foundBook != null)
            {
                Console.WriteLine("Book found:");
                Console.WriteLine(foundBook);
            }
            else
            {
                Console.WriteLine("Book not found!");
            }
        }
    }
}
