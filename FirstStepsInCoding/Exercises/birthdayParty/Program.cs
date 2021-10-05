using System;

namespace birthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double hallRent = double.Parse(Console.ReadLine());

            double cakePrice = hallRent * 20 / 100;
            
            double drinksPrice = cakePrice - (cakePrice * 45 / 100);
            
            double animatorPrice = hallRent / 3;
            

            double budget = cakePrice + drinksPrice + animatorPrice + hallRent;

            Console.WriteLine(budget);

        }
    }
}
