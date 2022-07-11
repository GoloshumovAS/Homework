using System;

namespace Homework13
{
    class Program
    {
        static void Main()
        {
            int cursorPosX;
            int cursorPosY = 0;
            Console.WriteLine("Введите слово");
            string userWord = Console.ReadLine();
            int wordLenght = userWord.Length + 1;
            Console.WriteLine("Введите обозначение границы");
            string borderSign = Console.ReadLine();

            Console.Clear();
            for(cursorPosX = 0; cursorPosX <= wordLenght; cursorPosX++)
            {
                Console.SetCursorPosition(cursorPosX, cursorPosY);
                Console.Write(borderSign);
            }
            cursorPosX = 1;
            cursorPosY = 1;

            Console.SetCursorPosition(cursorPosX, cursorPosY);
            Console.Write(userWord);

            cursorPosX = 0;
            cursorPosY = 1;

            Console.SetCursorPosition(cursorPosX, cursorPosY);
            Console.Write(borderSign);
            Console.SetCursorPosition(cursorPosX + wordLenght, cursorPosY);
            Console.Write(borderSign);

            cursorPosY = 2;

            for (cursorPosX = 0; cursorPosX <= wordLenght; cursorPosX++)
            {
                Console.SetCursorPosition(cursorPosX, cursorPosY);
                Console.Write(borderSign);
            }
        }
    }
}
