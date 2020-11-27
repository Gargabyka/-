using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobes
{
    [Serializable]
    public abstract class Person
    {     
        public string SurName { get; set; }
        public DateTime BrithDate { get; set; }
        public string Faculty { get; set; }
        public Person(string surname, DateTime brithDate, string faculty)
        {
            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new ArgumentNullException("Фамилия пользователя не может быть пустым", nameof(surname));
            }

            if((brithDate < DateTime.Parse("01.01.1900")) || (brithDate > DateTime.Now))
            {
                throw new ArgumentException("Неверно указанная дата.", nameof(brithDate));
            }

            if (string.IsNullOrWhiteSpace(faculty))
            {
                throw new ArgumentNullException("Факультет не может быть пустым", nameof(faculty));
            }

            SurName = surname;
            BrithDate = brithDate;
            Faculty = faculty;

        }

        public override string ToString()
        {
            return $"Фамилия:{SurName}\nДата рождения:{BrithDate.ToShortDateString()}\nВозраст:{Age(BrithDate)}\nФакультет:{Faculty}";
        }

        public int Age(DateTime date)
        {
            int age = DateTime.Now.Year - date.Year;
            if (DateTime.Now.Month < date.Month || (DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day))
            {
                age--;
            }
            return age;
        }
    }
}