using System;

namespace Homework17
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Введите строку из ( и ):");
            string stringBracket = Console.ReadLine();
            const char braketLeft = '(';
            int summBraketLeft = 0;
            const char braketRight = ')';
            int summBraketRight = 0;
            foreach (char allBraket in stringBracket)
            {
                switch (allBraket)
                {
                    case braketLeft:
                        summBraketLeft++;
                        break;
                    case braketRight:
                        summBraketRight++;
                        break;
                }
            }
            if (summBraketLeft == summBraketRight)
            {
                Console.WriteLine($"Строка {stringBracket} корректная и максимум глубины является {summBraketLeft}.");
            }
        }
    }
}
