using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int num = int.MinValue;
            int inputNum;
            while (text != "Stop")
            {
                inputNum = int.Parse(text);

                if (num < inputNum)
                {
                    num = inputNum;
                }
                text = Console.ReadLine();
            }

            Console.WriteLine(num);
        }
    }
}
