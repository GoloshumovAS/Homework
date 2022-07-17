using System;

namespace Homework19
{
    class Homework19
    {
        static void Main(string[] args)
        {
            int[,] mass = new int[,] { { 3, 2, 1 }, { 8, 7, 6 } };
            int sumSecondString = 0;
            int multFirstColumn = 1;
            for(int i = 0; i < mass.GetLength(0); i++)
            {
                for(int j = 0; j < mass.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        multFirstColumn *= mass[i, j];
                    }
                    if(i == 1)
                    {
                        sumSecondString += mass[i, j];
                    }
                    Console.Write(mass[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Произведение элементов первого столбца = {multFirstColumn}");
            Console.WriteLine($"Сумма элементов второй строки = {sumSecondString}");


        }
    }
}
