using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeSum = 0;
            int nonPrimeSum = 0;
            while (input != "stop")
            {
                int num = int.Parse(input);
                bool isPrime = true;

                if (num == 1)
                {
                    isPrime = false;
                }

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    num = 0;
                    
                }
                else
                {
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    primeSum += num;
                }
                else
                {
                    nonPrimeSum += num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
