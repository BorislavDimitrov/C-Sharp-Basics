using System;

namespace WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int firstSectorRows = int.Parse(Console.ReadLine());
            int placesInOddRow = int.Parse(Console.ReadLine());
            int currentSectorRows = firstSectorRows;
            int spotsCounter = 0;
            for (char i = (char)65; i <= lastSector; i++)
            {
                currentSectorRows++;
                
                int rowsCount = 0;
                for (int j = 1; j <= currentSectorRows - 1; j++)
                {
                    rowsCount++;
                    if (rowsCount % 2 == 0)
                    {
                        placesInOddRow += 2;
                    }
                    for (char k = (char)97; k < placesInOddRow + 97; k++)
                    {
                        
                            Console.WriteLine($"{i}{j}{k}");
                        spotsCounter++;
                        
                    }
                    if (rowsCount % 2 == 0)
                    {
                        placesInOddRow -= 2;
                    }
                }
            }
            Console.WriteLine($"{spotsCounter}");
        }
    }
}
