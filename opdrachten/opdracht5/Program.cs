using System;

namespace opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opdracht 5 - Book");

            Author author1 = new Author();
            author1.Name = "Jan Janssens";
            author1.Email = "jan.janssens@provider.be";
            author1.Gender = 'M';

            Book book1 = new Book("Hoe verdien je 40.000 euro door boeken te verkopen", author1, 40000.00, 1);

            // Testing print and getters.
            
            Console.WriteLine("\nFirst Print");
            book1.print();
            Console.WriteLine("\nTesting getters:");
            Console.WriteLine(book1.getName().ToString());
            Console.WriteLine(book1.getPrice().ToString());
            Console.WriteLine(book1.getQtyInStock().ToString());
            // Returns object class
            Console.WriteLine(book1.getAuthor());
            Console.WriteLine(book1.getAuthorName().ToString());

            // Testing Setters
            book1.setPrice(19999.99);
            book1.setQtyInStock(2);

            // Test changes.
            Console.WriteLine("\nSecond Print after testing setters:");
            book1.print();

        }
    }
}
