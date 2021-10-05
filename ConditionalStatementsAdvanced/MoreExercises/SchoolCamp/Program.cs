using System;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = 0.0;
            string sport = "Gf";

            if (season == "Winter")
            {
                if (groupType == "boys" || groupType == "girls")
                {
                    pricePerNight = 9.60;
                }
                else if (groupType == "mixed")
                {
                    pricePerNight = 10;
                }

                if (groupType == "girls")
                {
                    sport = "Gymnastics";
                }
                else if (groupType == "boys")
                {
                    sport = "Judo";
                }
                else if (groupType == "mixed")
                {
                    sport = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (groupType == "boys" || groupType == "girls")
                {
                    pricePerNight = 7.20;
                }
                else if (groupType == "mixed")
                {
                    pricePerNight = 9.50;
                }
               

                if (groupType == "girls")
                {
                    sport = "Athletics";
                }
                else if (groupType == "boys")
                {
                    sport = "Tennis";
                }
                else if (groupType == "mixed")
                {
                    sport = "Cycling";
                }
            }
            else if (season == "Summer")
            {
                if (groupType == "boys" || groupType == "girls")
                {
                    pricePerNight = 15;
                }
                else if (groupType == "mixed")
                {
                    pricePerNight = 20;
                }
                if (groupType == "girls")
                {
                    sport = "Volleyball";
                }
                else if (groupType == "boys")
                {
                    sport = "Football";
                }
                else if (groupType == "mixed")
                {
                    sport = "Swimming";
                }
            }
            double sum = students * pricePerNight * nights;
            
            if (students >= 50)
            {
                sum = sum - (sum * 50 / 100);
            }
            else if (students >= 20 && students < 50)
            {
                sum = sum - (sum * 15 / 100);
            }
            else if (students >= 10 && students < 20)
            {
                sum = sum - (sum * 5 / 100);
            }
            Console.WriteLine($"{sport} {sum:F2} lv.");
        }
    }
}
