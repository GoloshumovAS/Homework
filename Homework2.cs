using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите вашу профессию: ");
            string userProfession = Console.ReadLine();
            Console.WriteLine("Какой цвет ваш любимый?");
            string userFavoriteColor = Console.ReadLine();
            Console.WriteLine($"Вас зовут {userName}, вам {userAge} лет," +
                $" по специальности вы {userProfession} и ваш любимый цвет {userFavoriteColor}.");
        }
    }
}
