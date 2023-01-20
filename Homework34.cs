using System;
using System.Collections.Generic;

namespace Homework34
{
    class Homework34
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            string commandSum = "sum";
            string commandExit = "exit";
            bool isRun = true;
            Console.WriteLine($"Введите число в массив," +
                $" или команду {commandSum} для получения суммы элементов массива," +
                $" или команду {commandExit} для выхода ");

            CountNumbers(numbers, commandSum, commandExit, isRun);
        }
        static void CountNumbers(List<int> numbers, string sum, string exit, bool isRun)
        {
            int allSum = 0;
            while (isRun)
            {
                string userInput = Console.ReadLine();
                int newNumber;
                bool isNumber = int.TryParse(userInput, out newNumber);

                if (isNumber == true)
                {
                    numbers.Add(newNumber);
                }

                else if (userInput == sum)
                {
                    SumInputNumbers(numbers, allSum);
                }

                else if (userInput == exit)
                {
                    isRun = false;
                }
            }
        }
        static void SumInputNumbers(List<int> numbers, int allSum)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                allSum += numbers[i];
            }
            Console.WriteLine(allSum);
        }
    }
}
