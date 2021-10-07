using System;

namespace StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string secretCommand = "";
            char newChar;
            int cCounter = 0;
            int nCounter = 0;
            int oCounter = 0;
            string newWord = "";
            int newWordCounter = 0;

            while (input != "End")
            {
                newChar = char.Parse(input);
                if ((newChar >= 65 && newChar <= 90) || (newChar >= 97 && newChar <= 122))
                {
                    

                    if (newChar != 'c' && newChar != 'n' && newChar != 'o')
                    {
                        newWord += newChar;
                    }

                    if (newChar == 'c' && cCounter != 0)
                    {
                        newWord += newChar;
                    }
                    else if(newChar == 'c')
                    {
                        cCounter++;
                    }

                    if (newChar == 'n' && nCounter != 0)
                    {
                        newWord += newChar;
                    }
                    else if(newChar == 'n') 
                    {
                        nCounter++;
                    }

                    if (newChar == 'o' && oCounter != 0)
                    {
                        newWord += newChar;
                    }
                    else if (newChar == 'o') 
                    {
                        oCounter++;
                    }
                    if (cCounter != 0 && nCounter != 0 && oCounter != 0)
                    {
                        newWord += " ";
                        cCounter = 0;
                        nCounter = 0;
                        oCounter = 0;
                        newWordCounter++;
                        secretCommand = newWord;
                    }
                    
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(secretCommand);
        }
    }
}
