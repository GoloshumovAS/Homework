using System;

namespace Homework20
{
    class Program
    {
        static void Main()
        {
            int maxNumber = int.MinValue;
            Random random = new Random();
            int[,] arrayNumbers = new int[10, 10];

            for (int i = 0; i < arrayNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNumbers.GetLength(1); j++)
                {
                    arrayNumbers[i, j] = random.Next(1, 11);
                    if(arrayNumbers[i,j] > maxNumber)
                    {
                        maxNumber = arrayNumbers[i, j];
                    }
                    Console.Write(arrayNumbers[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for(int i = 0; i < arrayNumbers.GetLength(0); i++)
            {
                for(int j = 0; j < arrayNumbers.GetLength(1); j++)
                {
                    if(arrayNumbers[i,j] == maxNumber)
                    {
                        arrayNumbers[i, j] = 0;
                    }
                    Console.Write(arrayNumbers[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxNumber);
        }
    }
}
