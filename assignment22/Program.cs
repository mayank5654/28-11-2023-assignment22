using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\nLibrary Management System Menu:");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Search by Book ID");
                Console.WriteLine("4. Search by Title");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter book details:");
                            Book newBook = new Book
                            {
                                BookId = GetIntInput("Enter Book ID:"),
                                Title = GetStringInput("Enter Title:"),
                                Author = GetStringInput("Enter Author:"),
                                Genre = GetStringInput("Enter Genre:"),
                                IsAvailable = true
                            };
                            library.AddBook(newBook);
                            break;
                        case 2:
                            library.ViewAllBooks();
                            break;
                        case 3:
                            int searchId = GetIntInput("Enter Book ID to search:");
                            library.SearchBookById(searchId);
                            break;
                        case 4:
                            string searchTitle = GetStringInput("Enter Title to search:");
                            library.SearchBookByTitle(searchTitle);
                            break;
                        case 5:
                            Console.WriteLine("Exiting the program. Goodbye!");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        static int GetIntInput(string prompt)
        {
            int input;

            while (true)
            {
                Console.Write($"{prompt} ");
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }

        static string GetStringInput(string prompt)
        {
            Console.Write($"{prompt} ");
            return Console.ReadLine();
        }
    }
}
    

