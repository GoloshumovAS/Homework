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
            int [] money = new int[] {100,200,300};

            Queue<String> people = new Queue<string>();
            people.Enqueue("Andrey");
            people.Enqueue("Nikolay");
            people.Enqueue("Olga");
            Console.Clear();

            PurchaseInformation(earned, money, people);
        }

        static void PurchaseInformation(int earnedShop, int [] money, Queue<string> people)
        {
            for(int i = 0; i < money.Length; i++)
            {
                bool isWorks = true;
                Console.WriteLine($"Покупатель {people.Dequeue()} купил товар на {money[i]} монет");
                earnedShop += money[i];
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
