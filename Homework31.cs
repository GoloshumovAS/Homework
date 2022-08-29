using System;
//Реализуйте функцию Shuffle, которая перемешивает элементы массива в случайном порядке.
namespace Homework31
{
    class Homework31
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
                int numberReplace = random.Next(i);
                int arrayElement = array[numberReplace];
                array[numberReplace] = array[i];
                array[i] = arrayElement;
                Console.Write(array[i]);
            }
        }
    }
}
