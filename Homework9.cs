using System;

namespace ConsoleApp11
{
      class Program
    {
        static void Main()
        {
            int number = 7;
            int firstNumber = 5;
            int lastNumber = 96;
              
            for (int numberCount = firstNumber; numberCount <= lastNumber; numberCount += number)
            {
                Console.WriteLine(numberCount);
            }
        }
    }
}
