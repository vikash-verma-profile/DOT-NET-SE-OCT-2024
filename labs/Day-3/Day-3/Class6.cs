using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Book
    {
        private string title;
        private string author;
        private int totalPages;
        private bool isAvailable;

        public Book(string title, string author, int totalPages)
        {
            this.title = title;
            this.author = author;
            this.totalPages = totalPages;
            this.isAvailable = true;
        }

        public string GetBookInfo()
        {
            return $"{title} by {author}, Pages: {totalPages}";
        }

        public void BorrowBook()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"You have borrowed '{title}'.");
            }
            else
            {
                Console.WriteLine($"Sorry, '{title}' is not available.");
            }
        }

        public void ReturnBook()
        {
            isAvailable = true;
            Console.WriteLine($"You have returned '{title}'.");
        }

        public bool IsAvailable()
        {
            return isAvailable;
        }
    }

    class Class6
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);
            Book book2 = new Book("1984", "George Orwell", 328);

            Console.WriteLine(book1.GetBookInfo());
            Console.WriteLine($"Is available: {book1.IsAvailable()}");

            book1.BorrowBook();
            Console.WriteLine($"Is available: {book1.IsAvailable()}");

            book1.ReturnBook();
            Console.WriteLine($"Is available: {book1.IsAvailable()}");
        }
    }

}
