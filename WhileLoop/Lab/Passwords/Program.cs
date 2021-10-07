using System;

namespace Passwords
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string pass = Console.ReadLine();

            while (password != pass)
            {
                pass = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
