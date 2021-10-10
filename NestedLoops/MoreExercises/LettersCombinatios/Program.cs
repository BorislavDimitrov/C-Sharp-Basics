using System;

namespace LettersCombinatios
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 =char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char bannedLetter = char.Parse(Console.ReadLine());

            int counter = 0;
            for (char i = letter1; i <= letter2; i++)
            {
                for (char j = letter1; j <= letter2; j++)
                {
                    for (char k = letter1; k <= letter2; k++)
                    {
                        if (i != bannedLetter && j != bannedLetter && k != bannedLetter )
                        {
                            counter++;
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
            Console.Write(counter);
        }   
    }
}
