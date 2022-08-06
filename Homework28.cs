using System;

namespace Homework28
{
    class Program
    {
        static void Main()
        {
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("Введите процент заполненности шкалы здоровья:");
            int userPercent = Convert.ToInt32(Console.ReadLine());
            userPercent /= 10;
            Console.SetCursorPosition(10, 0);
            PaintHealthbar(userPercent);
        }
        static void PaintHealthbar(int size)
        {
            char[] array = new char[10];
            Console.Write('[');

            for (int i = 0; i < size; i++)
            {
                array[i] = '#';
                Console.Write(array[i]);
            }
                for (int i = size; i < array.Length; i++)
            {
                array[i] = '_';
                Console.Write(array[i]);
            }

            Console.Write(']');
        }
    }
}
