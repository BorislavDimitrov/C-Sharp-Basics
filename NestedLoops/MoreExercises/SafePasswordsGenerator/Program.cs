using System;

namespace SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxNumPasswords = int.Parse(Console.ReadLine());
            int counter = 0;
            int i = 35;
            int j = 64;

            for (int x = 1; x <= a; x++)
            {
                for (int y = 1; y <= b; y++)
                {

                    Console.Write($"{(char)i}{(char)j}{x}{y}{(char)j}{(char)i}|");
                    counter++;
                    i++;
                    j++;
                    if (i > 55)
                    {
                        i = 35;
                    }
                    if (j > 96)
                    {
                        j = 64;
                    }

                    if (counter >= maxNumPasswords)
                    {  
                        return;
                    }

                    
                }
                
                
            }
        }
    }
}
