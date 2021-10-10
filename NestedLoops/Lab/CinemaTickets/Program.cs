using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int freeSpots;
            string ticketType;

            double peoplePercent = 0;

            int movieTicketCount = 0;
            int studentTicketCount = 0;
            int standardTicketCount = 0;
            int kidTicketCount = 0;
            int resetCounter = 0;
            int percentCounter = 0;

            while (input != "Finish")
            {
                string movieName = input;
                freeSpots = int.Parse(Console.ReadLine());
                ticketType = Console.ReadLine();



                while (ticketType != "End")
                {
                    if (ticketType == "student")
                    {
                        studentTicketCount++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTicketCount++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTicketCount++;
                    }
                    resetCounter++;
                    movieTicketCount++;
                    percentCounter++;
                    

                    if (resetCounter == freeSpots)
                    {
                        resetCounter = 0;
                        break;
                    }
                    ticketType = Console.ReadLine();
                }



                peoplePercent = percentCounter * 1.00 / freeSpots * 1.00 * 100;

                Console.WriteLine($"{movieName} - {peoplePercent:F2}% full.");
                percentCounter = 0;
                peoplePercent = 0;
                resetCounter = 0;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {movieTicketCount}");

            double studentTicketsPercent = studentTicketCount * 1.00 / movieTicketCount * 1.00 * 100;
            Console.WriteLine($"{studentTicketsPercent:F2}% student tickets.");

            double standardTicketPercent = standardTicketCount * 1.00 / movieTicketCount * 1.00 * 100;
            Console.WriteLine($"{standardTicketPercent:F2}% standard tickets.");

            double kidTicketPercent = kidTicketCount * 1.00 / movieTicketCount * 1.00 * 100;
            Console.WriteLine($"{kidTicketPercent:F2}% kids tickets.");
        }
    }
}
