using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeSize = cakeLenght * cakeWidth;
            int piece = 0;
            int pieceSum = 0;
            string input = Console.ReadLine();

            while (input != "STOP" && pieceSum < cakeSize)
            {
                piece = int.Parse(input);
                pieceSum += piece;
                input = Console.ReadLine();
            }

            if (input == "STOP" && cakeSize > pieceSum)
            {
                Console.WriteLine($"{cakeSize - pieceSum} pieces are left.");
            }

            if (cakeSize < pieceSum)
            {
                Console.WriteLine($"No more cake left! You need {pieceSum - cakeSize} pieces more.");
            }
        }
    }
}
