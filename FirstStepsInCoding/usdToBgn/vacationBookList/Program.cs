using System;

namespace vacationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookNum = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int daysNum = int.Parse(Console.ReadLine());

            double totalTimeForAbook = bookNum / pagesPerHour;
            double hoursPerDayNeeded = totalTimeForAbook / daysNum;

            Console.WriteLine(hoursPerDayNeeded);
        }
    }
}
