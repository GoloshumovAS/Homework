using System;

namespace Homework29
{
    class Homework29
    {
        static void Main()
        {
            int number = GetNumber();
            Console.WriteLine($"Ваше число {number} сконвертированно");
        }
        static int GetNumber()
        {
            bool isWork = true;
            int value = 0;
            
            while (isWork)
            {
                Console.WriteLine("Введите число: ");
                string userInput = Console.ReadLine();

                bool canConvert = int.TryParse(userInput, out int number);

                if (canConvert == true)
                {
                    value = Convert.ToInt32(userInput);
                    isWork = false;
                }
                else
                {
                    Console.WriteLine("Попробуйте ввести другое число");
                }
            }

            return value;
        }
    }
}
