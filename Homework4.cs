using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "Ivanov";
            string userSurname = "Ivan";
            Console.WriteLine($"Ваше имя: {userName}, ваша фамилия {userSurname}");
            string buffer = userName;
            userName = userSurname;
            userSurname = buffer;
            Console.WriteLine($"Ваше имя: {userName}, ваша фамилия {userSurname}");
        }
    }
}
