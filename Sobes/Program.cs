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
                        person.CreationPerson(num, person.personList);
                        break;
                    case (2):
                        Console.Clear();
                        person.CreationPerson(num, person.personList);
                        break;

                    case (3):
                        Console.Clear();
                        person.CreationPerson(num, person.personList);
                        break;

                    case (4):
                        Console.Clear();
                        person.CreationPerson(num, person.personList);
                        break;

                    case (5):
                        person.FindPerson(person.personList);
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
       
    }
}
