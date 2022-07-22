using System;
namespace Homework22
{
    class Homework22
    {
        static void Main()
        {
            int[] array = new int[0];
            string commandSum = "sum";
            string commandExit = "exit";
            bool isRun = true;
            Console.WriteLine($"Введите число в массив," +
                $" или команду {commandSum} для получения суммы элементов массива," +
                $" или команду {commandExit} для выхода ");

            while (isRun)
            {
                string userInput = Console.ReadLine();

                if(userInput == commandExit)
                {
                    isRun = false;
                }

                else if(userInput == commandSum)
                {
                    int sumArray = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sumArray += array[i];
                    }

                    Console.WriteLine($"сумма элементов массива = {sumArray}");
                }

                else
                {
                    int userNumber = Convert.ToInt32(userInput);
                    int[] arrayChange = new int [array.Length + 1];
                    
                    for (int i = 0; i < array.Length; i++)
                    {
                        arrayChange[i] = array[i];
                    }
                    
                    arrayChange[arrayChange.Length - 1] = userNumber;
                    array = arrayChange;
                }
            }
        }
    }
}
