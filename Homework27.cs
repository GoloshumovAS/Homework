using System;
//Будет 2 массива: 1) фио 2) должность.
//Описать функцию заполнения массивов досье, функцию форматированного вывода, функцию поиска по фамилии и функцию удаления досье.
//Функция расширяет уже имеющийся массив на 1 и дописывает туда новое значение.
//Программа должна быть с меню, которое содержит пункты:
//1) добавить досье
//2) вывести все досье (в одну строку через “-” фио и должность с порядковым номером в начале)
//3) удалить досье(Массивы уменьшаются на один элемент.Нужны дополнительные проверки, чтобы не возникало ошибок)
//4) поиск по фамилии
//5) выход
namespace Homework27
{
    class Homework27
    {
        static void Main()
        {
            string[] arraySurname = { "Иванов","Петров","Сидоров"};
            string[] arrayJob = { "Программист","Художник","Менеджер"};
            bool stopProgramm = true;

            while (stopProgramm)
            {
                Console.WriteLine("Выберете пункт меню:\n" +
                    "1 - Добавить досье\n" +
                    "2 - Вывести все досье\n" +
                    "3 - Поиск по фамилии\n" +
                    "4 - Удалить досье\n" +
                    "5 - Выход\n");
                int command = Convert.ToInt32(Console.ReadLine());
                
                switch (command)
                {
                    case 1:
                        AddEmployee(ref arraySurname, ref arrayJob);
                        break;
                    case 2:
                        DisplayArray(arraySurname,arrayJob);
                        break;
                    case 3:
                        FindSurname(arraySurname,arrayJob);
                        break;
                    case 4:
                        DeleteFile(ref arraySurname, ref arrayJob);
                        break;
                    case 5:
                        stopProgramm = false;
                        break;
                }

                Console.WriteLine();
            }
        }
        static void AddEmployee(ref string[] surname, ref string[] job)
        {
            Console.WriteLine("Введите новую фамилию:");
            string newSurname = Console.ReadLine();
            Console.WriteLine("Введите должность:");
            string newJob = Console.ReadLine();

            ExpandArray(ref surname, newSurname);
            ExpandArray(ref job, newJob);
        }
        static void ExpandArray(ref string[] array, string userInput)
        {
            string[] newArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[^1] = userInput;
            array = newArray;
        }
        static void DisplayArray(string[] surname, string[] job)
        {
            for(int i = 0; i < surname.Length; i++)
            {
                Console.WriteLine($"{i + 1} {surname[i]} - {job[i]}");
            }
        }
        static void FindSurname(string[] surname, string[] job)
        {
            Console.WriteLine("Введите фамилию для поиска:");
            string surnameSearch = Console.ReadLine();

            for(int i = 0; i < surname.Length; i++)
            {
                if (surname[i] == surnameSearch)
                {
                    Console.WriteLine($"Сотрудник найден:\n {i} {surname[i]} - {job[i]}");
                }
                else if(surname[i] != surnameSearch && i+1 == surname.Length)
                {
                    Console.WriteLine("Сотрудник не найден, попробуйте снова");
                }
            }
        }
        static void DeleteFile(ref string[]surname, ref string[] job)
        {
            Console.WriteLine("Укажите номер записи для удаления:");
            int deleteNumber = Convert.ToInt32(Console.ReadLine());
            deleteNumber -= 1;
            OverwriteArray(ref surname, deleteNumber);
            OverwriteArray(ref job, deleteNumber);
        }
        static void OverwriteArray(ref string[] array, int number)
        {
            string[] deleteArray = new string[array.Length - 1];

            if (number < array.Length)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    deleteArray[i] = array[i];

                    if (i == number)
                    {
                        for (int j = i; j < array.Length - 1; j++)
                        {
                            deleteArray[j] = array[j + 1];
                        }
                        break;
                    }
                }

                array = deleteArray;
            }
            else
            {
                Console.WriteLine("Сотрудника с таким номером не существует!");
            }
        }
    }
}
