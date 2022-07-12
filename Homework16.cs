using System;

namespace Homework16
{
    class Program
    {
        static void Main()
        {

            Random random = new Random();
            int randomNumber = random.Next(1, 50);
            int stepDegree = 1;
            int numberDegree = (int)Math.Sqrt(randomNumber);
            int finalNumber = (int)Math.Pow(2, numberDegree);

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
/*Найдите минимальную степень двойки, превосходящую заданное число.
К примеру, для числа 4 будет 2 в степени 3, то есть 8. 4<8.
Для числа 29 будет 2 в степени 5, то есть 32. 29<32.
В консоль вывести число (лучше получить от Random), степень и само число 2 в найденной степени.*/