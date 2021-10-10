using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    Console.WriteLine($"{hours}:{min}");
                }
            }
        }
    }
}
