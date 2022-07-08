using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingTime = 10;
            int minutesInHours = 60;
            Console.WriteLine("Сколько людей в очереди?");
            int peopleInLine = Convert.ToInt32(Console.ReadLine());
            int timeInHours = waitingTime * peopleInLine / minutesInHours;
            int timeInMinutes = waitingTime * peopleInLine % minutesInHours;
            Console.WriteLine($"Время ожидания в очереди {timeInHours} час(а)" +
                $" {timeInMinutes} минут");
        }
    }
}
