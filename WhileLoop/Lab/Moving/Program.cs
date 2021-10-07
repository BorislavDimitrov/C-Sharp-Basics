using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int apartValue = width * lenght * height;

            string isItDone = Console.ReadLine();

            int box = 0;
            int boxValue = 0;

            while (isItDone != "Done")
            {
                box = int.Parse(isItDone);
                boxValue += box;
                

                if (apartValue < boxValue)
                {
                    int spaceNeeded = boxValue - apartValue;
                    Console.WriteLine($"No more free space! You need {Math.Abs(spaceNeeded)} Cubic meters more.");
                    break;
                }
                isItDone = Console.ReadLine();

            }

            if (isItDone == "Done")
            {
                int spaceLeft = apartValue - boxValue;
                Console.WriteLine($"{spaceLeft} Cubic meters left.");
               
            }
        }
    }
}