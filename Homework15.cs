using System;

namespace Homework15
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximumMultiple = 999;
            int lengthNuber = 3;
            Random rand = new Random();
            int randomNumber = rand.Next(0, 28);
            Console.WriteLine(randomNumber);

            for (int i = randomNumber; i < maximumMultiple; i += randomNumber)
            {
                if(Convert.ToString(i).Length >= lengthNuber)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
/*Дано N(1 ≤ N ≤ 27). Найти количество трехзначных натуральных чисел, которые кратны N. Операции деления (/, %)
не использовать.А умножение не требуется.
Число N всего одно, его надо получить в нужном диапазоне.*/
