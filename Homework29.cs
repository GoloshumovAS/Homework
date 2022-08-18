using System;
//Написать функцию, которая запрашивает число у пользователя (с помощью метода Console.ReadLine() ) и пытается сконвертировать его в тип int (с помощью int.TryParse())
//Если конвертация не удалась у пользователя запрашивается число повторно до тех пор, пока не будет введено верно. 
//После ввода, который удалось преобразовать в число, число возвращается.
//P.S Задача решается с помощью циклов
//P.S Также в TryParse используется модфикатор параметра out
namespace Homework29
{
    class Homework29
    {
        static void Main()
        {
            bool isStart = true;

            while (isStart)
            {
                Console.WriteLine("Введите число");
                string userInput = Console.ReadLine();
                bool isNumber = CheckValue(userInput);

                if(isNumber == true)
                {
                    Console.WriteLine($"Число {userInput} сконвертированно");
                    isStart = false;
                }
            }
        }
        
        static bool CheckValue(string userNumber)
        {
            bool isWork = true;
            bool isConvert = false;

            while (isWork)
            {
                bool canConvert = int.TryParse(userNumber, out int number);

                if (canConvert == true)
                {
                    isConvert = true;
                    isWork = false;
                }
                else
                {
                    Console.WriteLine("Попробуйте ввести другое число");
                    isWork = false;
                }
            }
            return isConvert;
        }
    }
}
