using System;
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
