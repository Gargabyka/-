using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobes
{  
    class Program
    {
        static void Main(string[] args)
        {

            var person = new PersonController();
            bool condition = true;
            int num = 0;

            while (condition)
            {
                Console.Clear();
                Info(out num);

                switch(num)
                {
                    case (1):
                        Console.Clear();
                        CreationPerson(num, person.personList);
                        break;
                    case (2):
                        Console.Clear();
                        CreationPerson(num, person.personList);
                        break;

                    case (3):
                        Console.Clear();
                        CreationPerson(num, person.personList);
                        break;

                    case (4):
                        Console.Clear();
                        CreationPerson(num, person.personList);
                        break;

                    case (5):
                        FindPerson(person.personList);
                        break;

                    case (6):                       
                        person.personList = person.Load();
                        break;
                    case (7):
                        Console.WriteLine("До свидания........");
                        condition = false;
                        break;
                }
            }

        }

        //Создание пользователя
        static void CreationPerson(int n, List<Person> personList)
        {
            var personController = new PersonController();
            Console.Write("Введите фамилию:");
            var surName = Console.ReadLine();
            var dateBirthday = ParseDateTime();
            Console.Write("Введите факультет:");
            var faculty = Console.ReadLine();

            //Администратор
            if (n == 1)
            {
                var adm = new Administrator(surName, dateBirthday, faculty);
                personList.Add(adm);
                Console.Clear();
                Console.WriteLine("Администратор успешно создан.... \nИнформация о нем.\n");
                Console.WriteLine(adm.ToString());
                Console.WriteLine("\nВыберете действие\n1)Вызов действия администратора\n2)Выход\nДействие:");

                var temp = Int32.Parse(Console.ReadLine());
                if (temp > 2 || temp < 1)
                {
                    Console.WriteLine("Нет такого действия");
                }
               
                if (temp == 1)
                {
                    Console.Clear();
                    adm.GetAction();
                    Console.WriteLine("\nНажмите любую кнопку для продолжения.....");
                    Console.ReadKey();
                }

                if (temp == 2)
                {

                    Console.WriteLine("\nНажмите любую кнопку для продолжения.....");
                    Console.ReadKey();
                    Console.Clear();
                }
                personController.Save(personList);
            }

            //Студент
            if(n == 2)
            {
                Console.Write("Введите курс:");
                var course = Int32.Parse(Console.ReadLine());
                var stud = new Student(surName, dateBirthday, faculty, course);
                personList.Add(stud);
                Console.Clear();
                Console.WriteLine("Студент успешно создан.... \nИнформация о нем.\n");
                Console.WriteLine(stud.ToString());

                Console.WriteLine("\nВыберете действие\n1)Вызов действия студента\n2)Выход\n");
                Console.Write("Действие:");
                var temp = Int32.Parse(Console.ReadLine());
                if (temp > 2 || temp < 1)
                {
                    Console.WriteLine("Нет такого действия");
                }

                if (temp == 1)
                {
                    Console.Clear();
                    stud.GetAction();
                    Console.WriteLine("\nНажмите любую кнопку для продолжения.....");
                    Console.ReadKey();
                }

                if (temp == 2)
                {

                    Console.WriteLine("\nНажмите любую кнопку для продолжения.....");
                    Console.ReadKey();
                    Console.Clear();
                }
                Console.Clear();

                if (temp == 2)
                {
                    Console.Clear();
                }
                personController.Save(personList);
            }

            //Преподаватель
            if(n == 3)
            {
                Console.Write("Введите должность:");
                var position = Console.ReadLine();
                Console.Write("Введите стаж:");
                var experience = Int32.Parse(Console.ReadLine());
                var teacher = new Teacher(surName, dateBirthday, faculty, position, experience);
                personList.Add(teacher);
                Console.Clear();
                Console.WriteLine("Преподаватель успешно создан.... \nИнформация о нем.\n");
                Console.WriteLine(teacher.ToString());

                Console.WriteLine("\nВыберете действие");
                Console.WriteLine("1)Вызов действия преподавателя");
                Console.WriteLine("2)Выход");
                Console.Write("Действие:");
                var temp = Int32.Parse(Console.ReadLine());
                if (temp > 2 || temp < 1)
                {
                    Console.WriteLine("Нет такого действия");
                }

                if (temp == 1)
                {
                    Console.Clear();
                    teacher.GetAction();
                    Console.WriteLine("\nНажмите любую кнопку для продолжения.....");
                    Console.ReadKey();
                }

                if (temp == 2)
                {

                    Console.WriteLine("\nНажмите любую кнопку для продолжения.....");
                    Console.ReadKey();
                    Console.Clear();
                }
                Console.Clear();

                if (temp == 2)
                {
                    Console.Clear();
                }
                personController.Save(personList);
            }


            //Менеджер
            if(n == 4)
            {
                Console.Write("Введите должность:");
                var position = Console.ReadLine();


                var manager = new Manager(surName, dateBirthday, faculty, position);
                personList.Add(manager);
                Console.Clear();
                Console.WriteLine("Менеджер успешно создан.... \nИнформация о нем.\n");
                Console.WriteLine(manager.ToString());

                Console.WriteLine("\nВыберете действие");
                Console.WriteLine("1)Вызов действия менеджера");
                Console.WriteLine("2)Выход");
                Console.Write("Действие:");
                var temp = Int32.Parse(Console.ReadLine());
                if (temp > 2 || temp < 1)
                {
                    Console.WriteLine("Нет такого действия");
                }

                if (temp == 1)
                {
                    Console.Clear();
                    manager.GetAction();
                    Console.WriteLine("\nНажмите любую кнопку для продолжения.....");
                    Console.ReadKey();
                }

                if (temp == 2)
                {

                    Console.WriteLine("\nНажмите любую кнопку для продолжения.....");
                    Console.Clear();
                    Console.ReadKey();
                }
                Console.Clear();

                if (temp == 2)
                {
                    Console.Clear();
                }
                personController.Save(personList);
            }

        }             
        
        //Поиск пользователя
        static void FindPerson(List<Person> personList)
        {
            Console.Clear();

            Console.WriteLine("1)Вывести всех пользователей");
            Console.WriteLine("2)Вывести по возрасту");
            int temp = Int32.Parse(Console.ReadLine());
            if (temp == 1)
            {
                Console.Clear();
                foreach (Person p in personList)
                {
                    Console.WriteLine($"\n{p}\n");
                }

                Console.WriteLine("Для продолжения нажмите любую клавишу....");
                Console.ReadKey();
            }

            if (temp == 2)
            {
                Console.Clear();
                int age, num;
                Console.WriteLine("1)Поиск пользователей старше n-возраста");
                Console.WriteLine("2)Поиск пользователей младше n-возраста");
                Console.WriteLine("3)Поиск пользователей равной n-возраста");

                num = Int32.Parse(Console.ReadLine());
                if(num > 3 || num < 1)
                {
                    Console.WriteLine("Ошибка. Такого раздела не существует");
                    Console.WriteLine("Нажмите любую кнопку для продолжения");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (num == 1)
                {
                    Console.WriteLine("Введите возраст:");
                    age = Int32.Parse(Console.ReadLine());
                    foreach (Person p in personList)
                    {
                        if (p.Age(p.BrithDate) > age)
                        {
                            Console.WriteLine($"\n{p}\n");
                        }
                    }
                    Console.WriteLine("Для продолжения нажмите любую клавишу....");
                    Console.ReadKey();
                }

                if (num == 2)
                {
                    Console.WriteLine("Введите возраст:");
                    age = Int32.Parse(Console.ReadLine());
                    foreach (Person p in personList)
                    {
                        if (p.Age(p.BrithDate) < age)
                        {
                            Console.WriteLine($"\n{p}\n");
                        }
                    }
                    Console.WriteLine("Для продолжения нажмите любую клавишу....");
                    Console.ReadKey();
                }

                if (num == 3)
                {
                    Console.WriteLine("Введите возраст:");
                    age = Int32.Parse(Console.ReadLine());
                    foreach (Person p in personList)
                    {
                        if (p.Age(p.BrithDate) == age)
                        {
                            Console.WriteLine($"\n{p}\n");
                        }
                    }
                    Console.WriteLine("Для продолжения нажмите любую клавишу....");
                    Console.ReadKey();
                }
            }
        }

        //Начальная информация
        static void Info(out int num)
        {
            Console.WriteLine("Создание пользователей учебного цента\n");
            Console.WriteLine("Выберете раздел...");
            Console.WriteLine("1)Создание администратора");
            Console.WriteLine("2)Создание студента");
            Console.WriteLine("3)Создание преподавателя");
            Console.WriteLine("4)Создание менеджера");
            Console.WriteLine("5)Поиск персон по возрасту");
            Console.WriteLine("6)Загрузка имеющихся пользователей");
            Console.WriteLine("7)Выход");

            Console.Write("\nВведите число:");
            num = Int32.Parse(Console.ReadLine());
            if (num > 7 || num < 1)
            {

                Console.WriteLine("Ошибка. Такого раздела не существует");
                Console.WriteLine("Нажмите любую кнопку для продолжения");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //Проверка даты
        private static DateTime ParseDateTime()
        {
            DateTime birthDate;
            while (true)
            {
                Console.Write("Введите дату рождения (yyyy.mm.dd):");
                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Неверный формат даты рождения");
                }
            }

            return birthDate;
        } 
    }
}
