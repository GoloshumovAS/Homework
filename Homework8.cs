using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {
            string exitWord = "go";

            while (exitWord == "exit")
            {
                exitWord = Console.ReadLine();
                Console.Write("Введите exit что бы остановить цикл: ");
            }
        }
    }
}
