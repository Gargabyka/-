using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sobes
{
    [Serializable]
    public class Student : Person, IEmployee
    {
        public int Course { get; set; }
        public Student(string surname, DateTime brithDate, string faculty,int course) : base(surname, brithDate, faculty)
        {
            if(course < 0 || course > 6)
            {
                throw new ArgumentException("Неверно указан курс", nameof(course));
            }

            SurName = surname;
            Faculty = faculty;
            Course = course;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nКурс:{Course}";
        }

        public void GetAction()
        {
            Console.WriteLine("Сколько ещё учиться осталось......");
            Thread.Sleep(1500);
            DateTime newyear = new DateTime(2020,12,31);
            int holidays = newyear.DayOfYear - DateTime.Now.DayOfYear;
            if(holidays != 0)
            {
                Console.WriteLine($"До новогодних каникул осталось {holidays} дней.....");
            }
            else
            {
                Console.WriteLine("Новогодние каникулы уже наступили!!!!");
            }

            Console.ReadKey();
            Console.Clear();
        }

    }
}
