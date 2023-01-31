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
            int allSum = 0;
            Console.WriteLine($"Введите число в массив," +
                $" или команду {commandSum} для получения суммы элементов массива," +
                $" или команду {commandExit} для выхода ");

            CheckCommand(numbers, commandSum, commandExit, allSum, isRun);
        }
        static void CheckCommand(List<int> numbers, string sum, string exit, int allSum, bool isRun)
        {
            while (isRun)
            {
                string userInput = Console.ReadLine();
                int newNumber;
                bool isNumber = int.TryParse(userInput, out newNumber);

                if (isNumber == true)
                {
                    AddNumbers(numbers, newNumber);
                }
                else if (userInput == sum)
                {
                    SumNumbers(numbers, allSum);
                }
                else if (userInput == exit)
                {
                    isRun = false;
                }
            }
        }
        static void AddNumbers(List<int> numbers, int newNumber)
        {
            numbers.Add(newNumber);
        }
        static void SumNumbers(List<int> numbers, int allSum)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                allSum += numbers[i];
            }
            Console.WriteLine(allSum);
        }
    }
}
