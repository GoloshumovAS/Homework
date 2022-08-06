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
                        Filling(ref arraySurname, ref arrayJob);
                        break;
                    case 2:
                        Conclusion(arraySurname,arrayJob);
                        break;
                    case 3:
                        FindSurname(ref arraySurname, ref arrayJob);
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
        static void Filling(ref string[] surname, ref string[] job)
        {
            Console.WriteLine("Введите новую фамилию:");
            string newSurname = Console.ReadLine();
            Console.WriteLine("Введите должность:");
            string newJob = Console.ReadLine();
            string[] newArraySurname = new string[surname.Length + 1];
            string[] newArrayJob = new string[job.Length + 1];

            for (int i = 0; i < surname.Length; i++)
            {
                newArraySurname[i] = surname[i];
            }
            
            newArraySurname[^1] = newSurname;
            surname = newArraySurname;
            
            for(int i = 0; i < job.Length; i++)
            {
                newArrayJob[i] = job[i];
            }
                
            newArrayJob[^1] = newJob;
            job = newArrayJob;
        }
        static void Conclusion(string[] surname, string[] job)
        {
            for(int i = 0; i < surname.Length; i++)
            {
                Console.WriteLine($"{i + 1} {surname[i]} - {job[i]}");
            }
        }
        static void FindSurname(ref string[] surname, ref string[] job)
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
            string[] deleteSurname = new string[surname.Length - 1];
            string[] deleteJob = new string[job.Length - 1];
            Console.WriteLine("Укажите номер записи для удаления:");
            int deleteNumber = Convert.ToInt32(Console.ReadLine());
            deleteNumber -= 1;

            if(deleteNumber < surname.Length)
            {
                for (int i = 0; i < surname.Length - 1; i++)
                {
                    deleteSurname[i] = surname[i];

                    if (i == deleteNumber)
                    {
                        for (int j = i; j < surname.Length - 1; j++)
                        {
                            deleteSurname[j] = surname[j + 1];
                        }
                        break;
                    }
                }

                surname = deleteSurname;

                for (int i = 0; i < job.Length - 1; i++)
                {
                    deleteJob[i] = job[i];

                    if (i == deleteNumber)
                    {
                        for (int j = i; j < job.Length - 1; j++)
                        {
                            deleteJob[j] = job[j + 1];
                        }
                        break;
                    }
                }
                job = deleteJob;
            }
            else
            {
                Console.WriteLine("Сотрудника с таким номером не существует!");
            }
        }
    }
}
