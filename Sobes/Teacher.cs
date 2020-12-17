using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sobes
{
    [Serializable]
    public class Teacher : Person, IEmployee
    {
        public string Position { get; set; }
        public int Experience { get; set; }
        public Teacher(string surname, DateTime brithDate, string faculty,string position,int experience) 
            : base(surname, brithDate, faculty)
        {
            if (string.IsNullOrWhiteSpace(position))
            {
                throw new ArgumentNullException("Должность не может быть пустой", nameof(position));
            }

            if (string.IsNullOrWhiteSpace(faculty))
            {
                throw new ArgumentNullException("Факультет не может быть пустым", nameof(faculty));
            }

            if (!(experience < Age(BrithDate) - 18 && experience > 0))
            {
                throw new ArgumentException("Неверно указан стаж", nameof(experience));
            }

            SurName = surname;
            Faculty = faculty;
            Position = position;
            Experience = experience;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nДолжность:{Position}\nСтаж:{Experience}";
        }

        public void GetAction()
        {
            Console.WriteLine("Сколько сейчас времени ?");
            Thread.Sleep(1500);
            Console.WriteLine("Ага............");
            Thread.Sleep(600);

            if(DateTime.Now.Hour > 8 && DateTime.Now.Hour < 18)
            {
                Console.WriteLine("Пора дармоедам преподавать науку!!!");
            }

            else
            {
                Console.WriteLine("Можно и отдохнуть наконец.....");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
