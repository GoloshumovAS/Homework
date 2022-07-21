using System;
//Пользователь вводит числа, и программа их запоминает.
//Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.

//Выход из программы должен происходить только в том случае, если пользователь введет команду exit.
//Если введено не sum и не exit, значит это число и его надо добавить в массив.

//Программа должна работать на основе расширения массива.
namespace Homework22
{
    class Program
    {
        static void Main()
        {
            int[] arrayNumbers = new int[1];
            int[] arrayNumbersChange = new int[arrayNumbers.Length + 1];
            int sumArray = 0;
            string commandSum = "sum";
            string commandExit = "exit";
            bool stopLoop = true;
            int userNumber;
            int counter = 0;
            string userInput;

            Console.WriteLine("Введите число в массив," +
                " или команду 'sum' для получения суммы элементов массива," +
                " или команду 'exit' для выхода ");

            while (stopLoop)
            {

                userInput = Console.ReadLine();
                if(userInput == commandExit)
                {
                    stopLoop = false;
                    break;
                }
                if(userInput == commandSum)
                {
                    for(int i = 0; i < arrayNumbers.Length; i++)
                    {
                        sumArray += arrayNumbers[i];
                    }

                    Console.WriteLine($"сумма элементов массива = {sumArray}");
                    arrayNumbers = new int[1];
                    counter = 0;
                    sumArray = 0;
                }
                else
                {
                    arrayNumbersChange = new int[arrayNumbers.Length + 1];
                    userNumber = Convert.ToInt32(userInput);
                    
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
