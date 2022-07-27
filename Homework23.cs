using System;
//В массиве чисел найдите самый длинный подмассив из одинаковых чисел.
//Дано 30 чисел. Вывести в консоль сам массив, число, которое само больше раз повторяется подряд и количество повторений.
//Дополнительный массив не надо создавать.
//Пример: { 5, 5, 9, 9, 9, 5, 5}
//-число 9 повторяется большее число раз подряд.
namespace Homework23
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[30];
            Random randomNumber = new Random();
            int countRep = 1;
            int countMax = 0;
            int finishVal = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumber.Next(0, 5);
                Console.Write(array[i] + " ");
            }

            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] == array[i-1])
                {
                    countRep++;
                    finishVal = array[i];
                }
                else
                {
                    countRep = 1;
                    
                }
                if (countRep > countMax)
                {
                    countMax = countRep; 
                }
            }

            for(int i = 0; i < countMax; i++)
            {
                Console.Write(finishVal);
            }
        }
    }
}
