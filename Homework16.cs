using System;

namespace Homework16
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 50);
            int baseNumber = 2;
            int stepDegree = 1;
            int numberDegree = (int)Math.Sqrt(randomNumber);
            int finalNumber = (int)Math.Pow(baseNumber, numberDegree);

            if (randomNumber >= finalNumber)
            {
                numberDegree += stepDegree;
                finalNumber = (int)Math.Pow(2, numberDegree);
            }

            Console.WriteLine($"Число - {randomNumber}, " +
                $"степень числа {numberDegree}, " +
                $"число в степени {finalNumber}");
        }
    }
}
