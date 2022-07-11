using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main()
        {
            int rubToUsd = 64, usdToRub = 66, rubToEur = 70, eurToRub = 74;
            float usdToEur = 1.1f, eurToUsd = 1.3f;
            float rubCount = 10000;
            float usdCount = 500;
            float eurCount = 500;
            string exitFromATM = "start";

            while (exitFromATM != "exit")
            {
                Console.WriteLine($"У вас на счете:\n {rubCount} руб\n {usdCount} usd\n {eurCount} eur");
                Console.WriteLine("Укажите валюту для обмена:\n 1 - Rub\n 2 - Usd\n 3 - Eur");
                string moneyExchange = Console.ReadLine();
                Console.WriteLine("Укажите требуемую валюту:\n 1 - Rub\n 2 - Usd\n 3 - Eur");
                string moneyReceived = Console.ReadLine();
                Console.WriteLine("Укажите сумму обмена:");
                float moneyCount = Convert.ToSingle(Console.ReadLine());

                if (moneyExchange == moneyReceived)
                {
                    Console.WriteLine("Недопустимаяя операция");
                }

                switch (moneyExchange)
                {
                    case "1":
                        if (moneyReceived == "2")
                        {
                            rubCount -= moneyCount;
                            usdCount += moneyCount / rubToUsd;
                            Console.WriteLine($"у вас на счете:\n {rubCount} руб\n {usdCount} usd\n {eurCount} eur");
                        }
                        else if (moneyReceived == "3")
                        {
                            rubCount -= moneyCount;
                            eurCount += moneyCount / rubToEur;
                            Console.WriteLine($"у вас на счете:\n {rubCount} руб\n {usdCount} usd\n {eurCount} eur");
                        }
                        break;
                    case "2":
                        if (moneyReceived == "1")
                        {
                            usdCount -= moneyCount;
                            rubCount += moneyCount * usdToRub;
                            Console.WriteLine($"у вас на счете:\n {rubCount} руб\n {usdCount} usd\n {eurCount} eur");
                        }
                        else if (moneyReceived == "3")
                        {
                            usdCount -= moneyCount;
                            eurCount += moneyCount * usdToEur;
                            Console.WriteLine($"у вас на счете:\n {rubCount} руб\n {usdCount} usd\n {eurCount} eur");
                        }
                        break;
                    case "3":
                        if (moneyReceived == "1")
                        {
                            eurCount -= moneyCount;
                            rubCount += moneyCount * eurToRub;
                            Console.WriteLine($"у вас на счете:\n {rubCount} руб\n {usdCount} usd\n {eurCount} eur");
                        }
                        else if (moneyReceived == "2")
                        {
                            eurCount -= moneyCount;
                            usdCount += moneyCount * eurToUsd;
                            Console.WriteLine($"у вас на счете:\n {rubCount} руб\n {usdCount} usd\n {eurCount} eur");
                        }
                        break;
                }
                Console.WriteLine("Для выхода введите exit");
                exitFromATM = Console.ReadLine();
            }
        }
    }
}
