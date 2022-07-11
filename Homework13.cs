using System;

namespace Homework13
{
    class Program
    {
        static void Main()
        {
            int cursorPosX;
            int startPosX = 0;
            int cursorPosY = 0;
            int stepCursorX = 1;
            int stepCursorY = 1;
            int stepLength = 1;
            string borderString = "";
            
            Console.WriteLine("Введите слово");
            string userWord = Console.ReadLine();
            int wordLength = userWord.Length + stepLength;
            Console.WriteLine("Введите обозначение границы");
            string borderSign = Console.ReadLine();

            Console.Clear();
            for(cursorPosX = startPosX; cursorPosX <= wordLength; cursorPosX++)
            {
                Console.SetCursorPosition(cursorPosX, cursorPosY);
                Console.Write(borderSign);
                borderString += borderSign;
            }

            cursorPosX = startPosX;
            cursorPosY += stepCursorY;
            Console.SetCursorPosition(cursorPosX, cursorPosY);
            Console.WriteLine(borderSign + userWord + borderSign);
            Console.WriteLine(borderString);
        }
    }
}
