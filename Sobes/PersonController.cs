using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sobes
{
    public class PersonController
    {
        //Создание списка пользователей
        public List<Person> personList = new List<Person>();


        //Сохранение пользователей
        public void Save(List<Person> personList)
        {
            var serializer = new BinaryFormatter();
            using (var writer = new FileStream("person.dat", FileMode.OpenOrCreate))
            {
                serializer.Serialize(writer, personList);
            }
        }

        
        //Загрузка пользователей
        public List<Person> Load()
        {
            var serializer = new BinaryFormatter();
            using (var reader = new FileStream("person.dat",FileMode.OpenOrCreate))
            {
                return (List<Person>)serializer.Deserialize(reader);
            }

        }

        //Создание пользователей
        public void CreationPerson(int n, List<Person> personList)
        {
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
                Save(personList);
            }

            //Студент
            if (n == 2)
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
                Save(personList);
            }

            //Преподаватель
            if (n == 3)
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
                Save(personList);
            }


            //Менеджер
            if (n == 4)
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
                Save(personList);
            }

        }

        //Проверка даты
        public DateTime ParseDateTime()
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

        //Поиск пользователя
        public void FindPerson(List<Person> personList)
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
                if (num > 3 || num < 1)
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
    }
}
