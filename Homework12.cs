using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            string userPassword = "";
            string consoleTitle;
            int consoleSizeX;
            int consoleSizeY;
            string exitFromMenu = "start";

            while (exitFromMenu != "exit")
            {
                Console.WriteLine("Введите команду:\n" +
                "userName - ввести имя пользователя\n" +
                "userPassword -ввести пароль пользователя\n" +
                "userInfo - информация о пользователе\n" +
                "consoleTitle - изменить заголовок консоли\n" +
                "consoleColor - изменить цвет консоли\n" +
                "consoleSize - изменить размер консоли\n");

                string inputDate = Console.ReadLine();
                switch (inputDate)
                {
                    case "userName":
                        Console.WriteLine("Введите имя пользователя:");
                        userName = Console.ReadLine();
                        break;
                    case "userPassword":
                        Console.WriteLine("Введите пароль пользователя:");
                        userPassword = Console.ReadLine();
                        break;
                    case "userInfo":
                        Console.WriteLine($"имя пользователя: {userName}\nпароль пользователя: {userPassword}");
                        break;
                    case "consoleTitle":
                        Console.WriteLine("Введите заголовок консоли:");
                        consoleTitle = Console.ReadLine();
                        Console.Title = consoleTitle;
                        break;
                    case "consoleColor":
                        Console.WriteLine("Выберете цвет консоли:\n White\n Red\n Blue");
                        string inputColor = Console.ReadLine();
                        if (inputColor == "White")
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Clear();
                        }
                        else if (inputColor == "Red")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Clear();
                        }
                        else if (inputColor == "Blue")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Clear();
                        }
                        break;
                    case "consoleSize":
                        Console.WriteLine("Введите размер консоли:");
                        Console.WriteLine("Размер по вериткали:");
                        consoleSizeX = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Размер по горизонтали:");
                        consoleSizeY = Convert.ToInt32(Console.ReadLine());
                        Console.WindowHeight = consoleSizeY;
                        Console.WindowWidth = consoleSizeX;
                        break;
                }
                Console.WriteLine("для выхода из меню введите exit\n" +
                    "для продолжения работы нажмите любую кнопку");
                exitFromMenu = Console.ReadLine();
            }
        }
    }
}
