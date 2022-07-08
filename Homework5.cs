using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceCrystal = 10;

            Console.WriteLine("Введите кол-во золота:");
            int countGold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько кристаллов вы хотите купить?");
            int countCrystal = Convert.ToInt32(Console.ReadLine());

            countGold -= countCrystal * priceCrystal;

            Console.WriteLine($"вы купили {countCrystal} кристалов" +
                $" и у вас осталось {countGold} золота");
        }
    }
}
