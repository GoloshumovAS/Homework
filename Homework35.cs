using System;
using System.Collections.Generic;
namespace Homework35
{
    class Homework35
    {
        static void Main(string[] args)
        {
            const int CommandAddEmloyee = 1;
            const int CommandDisplayDict = 2;
            const int CommandDeleteFile = 3;
            const int CommandExitProgramm = 4;
            bool stopProgramm = true;
            Dictionary<string, string> employeesFile = new Dictionary<string, string>();
            employeesFile.Add("Иванов А.П.", "Программист");
            employeesFile.Add("Сидоров Г.Ш.", "Инженер");
            employeesFile.Add("Петров И.Ю.", "Менеджер");

            while (stopProgramm)
            {
                Console.WriteLine("Выберете пункт меню:\n" +
                    $"{CommandAddEmloyee} - Добавить досье\n" +
                    $"{CommandDisplayDict} - Вывести все досье\n" +
                    $"{CommandDeleteFile} - Удалить досье\n" +
                    $"{CommandExitProgramm} - Выход\n");
                int command = Convert.ToInt32(Console.ReadLine());

                switch (command)
                {
                    case CommandAddEmloyee:
                        AddEmployee(employeesFile);
                        break;
                    case CommandDisplayDict:
                        DisplayDictEmployee(employeesFile);
                        break;
                    case CommandDeleteFile:
                        DeleteFile(employeesFile);
                        break;
                    case CommandExitProgramm:
                        stopProgramm = false;
                        break;
                }

                Console.WriteLine();
            }
        }
        static void AddEmployee(Dictionary<string, string> employeesFile)
        {
            Console.Write("Введите ФИО: ");
            string inputFullName = Console.ReadLine();
            Console.Write("Введите должность: ");
            string inputEmployeePosition = Console.ReadLine();
            employeesFile.Add(inputFullName, inputEmployeePosition);
        }
        static void DisplayDictEmployee(Dictionary<string, string> employeesFile)
        {
            foreach (KeyValuePair<string, string> kvp in employeesFile)
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
