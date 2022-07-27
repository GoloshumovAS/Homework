using System;
//Дан массив чисел (минимум 10 чисел). Надо вывести в консоль числа отсортированы, от меньшего до большего.
//Нельзя использовать Array.Sort. Можно найти подходящий алгоритм сортировки и использовать его для задачи.
namespace Homework24
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write(array[i] + " ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int number = array[i];
                        array[i] = array[j];
                        array[j] = number;
                    }
                }
            }

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
