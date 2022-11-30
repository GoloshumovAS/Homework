using System;
using System.Collections.Generic;

//Создать программу, которая принимает от пользователя слово и выводит его значение.
//Если такого слова нет, то следует вывести соответствующее сообщение.
namespace Homework32
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите слово - ");
            string userWord = Console.ReadLine().ToLower();

            string key1 = "c";
            string key2 = "java";
            string key3 = "javascript";
            string answer1 = "Вы сделали лошадь";
            string answer2 = "Вы очень хотите сделать лошадь";
            string answer3 = "Вам прислали лошадь в разных пакетах";

            Dictionary<string, string> question = new Dictionary<string, string>();
            question.Add(key1,answer1 );
            question.Add(key2,answer2 );
            question.Add(key3,answer3 );

            ResponseToUser(userWord, question);
        }

        static void ResponseToUser(string word, Dictionary<string,string> question)
        {
            foreach(KeyValuePair<string, string> item in question)
            {
                if (question.ContainsKey(word))
                {
                    Console.WriteLine($"ваш ответ:  {question[word]}");
                    break;
                }
                else
                {
                    Console.WriteLine("Ответа на ваш запрос нет.");
                    break;
                }
            }
        }
    }
}
