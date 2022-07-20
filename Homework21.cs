using System;

namespace Homework21
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int localMax = int.MinValue;
            int[] arrayNumbers = new int[30];

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = random.Next(0, 20);
                Console.Write(arrayNumbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("-----------");

            if (arrayNumbers[0] > arrayNumbers[1])
            {
                localMax = arrayNumbers[0];
                Console.WriteLine(localMax);
            }

            for (int i = 1; i < arrayNumbers.Length - 1; i++)
            {
                if (arrayNumbers[i] > arrayNumbers[i + 1] && arrayNumbers[i] > arrayNumbers[i - 1])
                {
                    localMax = arrayNumbers[i];
                    Console.WriteLine(localMax);
                }
            }

            if (arrayNumbers[^1] > arrayNumbers[^2])
            {
                localMax = arrayNumbers[^1];
                Console.WriteLine(localMax);
            }
        }
    }
}
