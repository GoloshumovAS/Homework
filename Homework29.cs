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
            bool startLoop = true;

            while (startLoop)
            {
                Console.WriteLine("Введите число");
                string userInput = Console.ReadLine();
                Number(userInput, ref startLoop);
                if (startLoop != true)
                {
                    Console.WriteLine($"Число {userInput} сконвертированно");
                }
            }
        }
        static void Number(string userNumber, ref bool runLoop)
        {

            while (runLoop)
            {
                bool convertResult = int.TryParse(userNumber, out int number);

                if (convertResult == true)
                {
                    runLoop = false;
                }
                else
                {
                    Console.WriteLine("Попробуйте ввести другое число");
                    break;
                }
            }
        }
    }
}
