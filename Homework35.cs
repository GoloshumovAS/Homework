using System;
using System.Collections.Generic;
namespace Homework35
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stopProgramm = true;
            Dictionary<string, string> employeesFile = new Dictionary<string, string>();
            employeesFile.Add("Иванов А.П.", "Программист");
            employeesFile.Add("Сидоров Г.Ш.", "Инженер");
            employeesFile.Add("Петров И.Ю.", "Менеджер");

            while (stopProgramm)
            {
                Console.WriteLine("Выберете пункт меню:\n" +
                    "1 - Добавить досье\n" +
                    "2 - Вывести все досье\n" +
                    "3 - Удалить досье\n" +
                    "4 - Выход\n");
                int command = Convert.ToInt32(Console.ReadLine());

                switch (command)
                {
                    case 1:
                        AddEmployee(employeesFile);
                        break;
                    case 2:
                        DisplayArray(employeesFile);
                        break;
                    case 3:
                        DeleteFile(employeesFile);
                        break;
                    case 4:
                        stopProgramm = false;
                        break;
                }

                Console.WriteLine();
            }
        }
        static void AddEmployee(Dictionary<string, string> employeesFile) {
            Console.Write("Введите ФИО: ");
            string userKey = Console.ReadLine();
            Console.Write("Введите должность: ");
            string userValue = Console.ReadLine();
            employeesFile.Add(userKey, userValue);
        }

        static void DisplayArray(Dictionary<string, string> employeesFile)
        {
            foreach(KeyValuePair<string,string> kvp in employeesFile)
            {
                
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }

        static void DeleteFile(Dictionary<string, string> employeesFile)
        {
            Console.Write("Введите ФИО для удаления: ");
            string userDelete = Console.ReadLine();
            employeesFile.Remove(userDelete);
        }
    }
}