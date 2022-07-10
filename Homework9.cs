using System;

namespace ConsoleApp11
{
      class Program
    {
        static void Main()
        {
            int number = 7;

            for (int numberCount = 5; numberCount <= 96; numberCount += number)
            {
                Console.WriteLine(numberCount);
            }
        }
    }
}
