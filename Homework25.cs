using System;
//Дана строка с текстом, используя метод строки String.Split() получить массив слов, которые разделены пробелом в тексте и вывести массив, каждое слово с новой строки.
namespace Homework25
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Точки исчезли из подстрок, однако теперь появились две дополнительные пустые подстроки.";
            string[] array = text.Split(' ');
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}