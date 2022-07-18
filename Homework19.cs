using System;

namespace Homework19
{
    class Homework19
    {
        static void Main()
        {
            int[,] arrayNumbers = new int[,] { { 3, 2, 1 }, { 8, 7, 6 } };
            int sumSecondString = 0;
            int multFirstColumn = 1;

            for(int i = 0;i < arrayNumbers.GetLength(0); i++)
            {
                for(int j = 0; j < arrayNumbers.GetLength(1); j++)
                {
                    Console.Write(arrayNumbers[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < arrayNumbers.GetLength(0); i++)
            {
                multFirstColumn *= arrayNumbers[i, 0];
            }

            for(int i = 0; i < arrayNumbers.GetLength(1); i++)
            {
                sumSecondString += arrayNumbers[1, i];
            }

            Console.WriteLine();
            Console.WriteLine($"Произведение элементов первого столбца = {multFirstColumn}");
            Console.WriteLine($"Сумма элементов второй строки = {sumSecondString}");
        }
    }
}
