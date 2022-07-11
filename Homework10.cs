using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(0, 100);
            int numberSum = 0;

            for(int i = 0; i <= number; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    numberSum += i;
                }
            }

            Console.WriteLine(numberSum);
        }
    }
}
