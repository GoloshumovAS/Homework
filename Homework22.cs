using System;
namespace Homework22
{
    class Homework22
    {
        static void Main()
        {
            int[] arrayNumbers = new int[0];
            string commandSum = "sum";
            string commandExit = "exit";
            bool stopLoop = true;
            int counter = 0;
            Console.WriteLine($"Введите число в массив," +
                $" или команду {commandSum} для получения суммы элементов массива," +
                $" или команду {commandExit} для выхода ");
            
            while (stopLoop)
            {
                string userInput = Console.ReadLine();

                if(userInput == commandExit)
                {
                    stopLoop = false;
                }

                else if(userInput == commandSum)
                {
                    int sumArray = 0;
                    
                    for (int i = 0; i < arrayNumbers.Length; i++)
                    {
                        sumArray += arrayNumbers[i];
                    }
                    
                    Console.WriteLine($"сумма элементов массива = {sumArray}");
                }

                else
                {
                    int userNumber = Convert.ToInt32(userInput);
                    int[] arrayNumbersChange = new int[arrayNumbers.Length + 1];

                    for (int i = 0; i < arrayNumbers.Length; i++)
                    {
                        arrayNumbersChange[i] = arrayNumbers[i];
                    }

                    arrayNumbers = arrayNumbersChange;
                    arrayNumbers[counter] = userNumber;
                    counter++;
                }
            }
        }
    }
}
