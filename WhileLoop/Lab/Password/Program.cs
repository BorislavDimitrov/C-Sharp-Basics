using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int newNum = 1;

            while (newNum <= n)
            {
                Console.WriteLine(newNum);
                newNum = newNum * 2 + 1; //newNum *= 2 + 1;
            }
        }
    }
}
