using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char textSymbol = 'a';
            double sum = 0;
            for (int i = 0; i < text.Length ; i++)
            {
                textSymbol = text[i];
                switch (textSymbol)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                    default:
                        break;
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
