using System;
//Реализуйте функцию Shuffle, которая перемешивает элементы массива в случайном порядке.
namespace Homework31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, array.Length);
                Console.Write(array[i]);
            }
            Console.WriteLine();
            Shuffle(array);
        }

        static void Shuffle(int[] array)
        {
            Random random = new Random();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int j = random.Next(i);
                var temp = array[j];
                array[j] = array[i];
                array[i] = temp;
                Console.Write(array[i]);
            }
        }
    }
}
