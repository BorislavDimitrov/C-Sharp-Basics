using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int num = int.MaxValue;
            int newNum;

            while (text != "Stop")
            {
                newNum = int.Parse(text);

                if (num > newNum)
                {
                    num = newNum;
                }

                text = Console.ReadLine();
            }

            Console.WriteLine(num);
        }
    }
}
