using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine(i);
                i++;
                Console.Write("Введите exit что бы остановить цикл: ");
                string exiteWord = Console.ReadLine();
                if (exiteWord == "exit")
                {
                    break;
                }
            }
        }
    }
}
