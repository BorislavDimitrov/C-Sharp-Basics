using System;

namespace TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            string password = "";
            bool isPassword = false;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (((a * b) + (c * d) == controlNumber) && a < b && c > d)
                            {
                                counter++;
                                Console.Write($"{a}{b}{c}{d} ");

                                if (counter == 4)
                                {
                                    password = $"{a}{b}{c}{d}";
                                    isPassword = true;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();

            if (isPassword)
            {
                Console.WriteLine("Password: " + password);
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
