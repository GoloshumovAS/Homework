using System;
using System.Collections.Generic;
//У вас есть множество целых чисел. Каждое целое число - это сумма покупки.
//Вам нужно обслуживать клиентов до тех пор, пока очередь не станет пуста.
//После каждого обслуженного клиента деньги нужно добавлять на наш счёт и выводить его в консоль.
//После обслуживания каждого клиента программа ожидает нажатия любой клавиши, 
//после чего затирает консоль и по новой выводит всю информацию, только уже со следующим клиентом
namespace Homework33
{
    class Program
    {
        static void Main(string[] args)
        {
            int earnedShop = 0;
            int [] buyerMoney = new int[] {100,200,300};

            Queue<String> buyer = new Queue<string>();
            buyer.Enqueue("Andrey");
            buyer.Enqueue("Nikolay");
            buyer.Enqueue("Olga");
            Console.Clear();

            PurchaseInformation(earnedShop, buyerMoney, buyer);
        }

        static void PurchaseInformation(int earnedShop, int [] buyerMoney, Queue<string> buyer)
        {
            for(int i = 0; i < buyerMoney.Length; i++)
            {
                bool isWorks = true;
                Console.WriteLine($"Покупатель {buyer.Dequeue()} купил товар на {buyerMoney[i]} монет");
                earnedShop += buyerMoney[i];
                Console.WriteLine($"на нашем счете {earnedShop} монет");

                while (isWorks)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        isWorks = false;
                    }
                }
            }
        }
    }
}
