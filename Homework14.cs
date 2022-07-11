using System;

namespace Homework14
{
    class Program
    {
        static void Main()
        {
            int numberOfAttempts = 2;
            string userPassword = "qwerty123";
            Console.Write("Введите пароль:");
            string inputPassword = Console.ReadLine();

            for(int i = 0; i < numberOfAttempts; i++)
            {
                if(inputPassword == userPassword)
                {
                    Console.WriteLine("Тут было секретное сообщение...\n" +
                        "нажмите любую клавишу что бы выйти");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine($"Неверный пароль. У вас осталось {numberOfAttempts - i} попыток.");
                    inputPassword = Console.ReadLine();
                }
            }
        }
    }
}
