using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sobes
{
    [Serializable]
    class Manager : Person, IEmployee
    {

        public string Position { get; set; }
        public Manager(string surname, DateTime brithDate, string faculty, string position) 
            : base(surname, brithDate, faculty)
        {
            if (string.IsNullOrWhiteSpace(position))
            {
                throw new ArgumentNullException("Должность не может быть пустой", nameof(position));
            }

            SurName = surname;
            Faculty = faculty;
            Position = position;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nФакультет:{Faculty}\nДолжность:{Position}";
        }

        public void GetAction()
        {
            Random random = new Random();
            var temp = random.Next(0, 150);
            Console.WriteLine("Сколько сегодня придется разбирать писем ?");
            Thread.Sleep(1500);
            Console.WriteLine($"На вашем почтовом ящике {temp} новых писем");

            if (temp > 0 && temp < 50)
            {
                Console.WriteLine("Сегодня ещё не так много");
            }

            if (temp > 50 && temp < 100)
            {
                Console.WriteLine("Меня начинает это напрягать......");
            }

            if (temp > 100)
            {
                Console.WriteLine($"На вашем почтовом ящике {temp} новых писем");
                Console.WriteLine("Это какой-то ужас!!!!");
            }
        }
    }
}
