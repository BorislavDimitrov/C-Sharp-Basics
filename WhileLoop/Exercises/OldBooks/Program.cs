using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();

            string input = Console.ReadLine();
            int bookCounter = 0;

            while (input != favouriteBook && input != "No More Books")
            {
                bookCounter++;
                input = Console.ReadLine();
            }

            if (input == favouriteBook)
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCounter} books.");
            }
           

        }
    }
}
