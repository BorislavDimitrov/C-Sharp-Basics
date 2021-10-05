using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0.0;
            double apartmentPrice = 0.0;
            double studioSum = 0.0;
            double apartSum = 0.0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;
                 studioSum = studioPrice * nights;
                 apartSum = apartmentPrice * nights;
                
                if (nights > 14)
                {
                    studioSum-= studioSum * 30 / 100;
                }
                else if (nights > 7)
                {
                    studioSum -= studioSum * 5 / 100;
                }
                if (nights > 14)
                {
                    apartSum -= apartSum * 10 / 100;
                }

                
            }
            else if (month == "September" || month == "June")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
                 studioSum = studioPrice * nights;
                 apartSum = apartmentPrice * nights;
                if (nights > 14)
                {
                    apartSum -= apartSum * 10 / 100;
                }
                if (nights > 14)
                {
                    studioSum -= studioSum * 20 / 100;
                }
                
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                apartmentPrice = 77;
                 studioSum = studioPrice * nights;
                 apartSum = apartmentPrice * nights;
                if (nights > 14)
                {
                    apartSum -= apartSum * 10 / 100;
                }
            }
            Console.WriteLine($"Apartment: {apartSum:F2} lv.");
            Console.WriteLine($"Studio: {studioSum:F2} lv.");
        }
        
        
    }
}
