using System;
//Дан массив чисел. Нужно его сдвинуть циклически на указанное пользователем значение позиций влево, не используя других массивов. 
//Пример для сдвига один раз: { 1, 2, 3, 4} => { 2, 3, 4, 1}
namespace Homework26
{
    class Program
    {
        static void Main()
        {
            int[] array = {1,2,3,4,5};

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Укажите смещение массива на кол-во позиций: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < number; i++)
            {
                int temp = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[^1] = temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}
