using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");
            string inputWord = Console.ReadLine();
            Console.WriteLine("Введите число повторений");
            int wordCount = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i < wordCount; i++)
            {
                Console.WriteLine(inputWord);
            }
        }
    }
}
