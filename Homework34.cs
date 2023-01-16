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

            AddNumbers(numbers, commandSum, commandExit, isRun);
        }
        
        static void AddNumbers(List<int> numbers, string sum, string exit, bool isRun)
        {
            int allSum = 0;
            
            while (isRun)
            {
                string userInput = Console.ReadLine();
                int value;
                bool isNumber = int.TryParse(userInput, out value);

                if (isNumber == true)
                {
                    numbers.Add(value);
                }

                else if (userInput == sum)
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        allSum += numbers[i];
                    }
                    Console.WriteLine(allSum);
                }
                
                else if (userInput == exit)
                {
                    isRun = false;
                }
            }
        }
    }
}
