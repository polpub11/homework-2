using System;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Book objects
            Book book1 = new Book("1984", "George Orwell");
            Book book2 = new Book("The Hobbit", "J.R.R. Tolkien", 310);

            // Check out book1 and return book2
            book1.CheckOut();
            book2.ReturnBook();

            // Print book details using overridden ToString method
            Console.WriteLine(book1.ToString());
            Console.WriteLine(book2.ToString());
        }
    }
}

