using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 

namespace Sobes
{

    [Serializable]
    public class Administrator : Person, IEmployee
    {
        public Administrator()
        {

        }
        public Administrator(string surname, DateTime brithDate, string faculty) : base(surname, brithDate, faculty)
        {
            SurName = surname;
            Faculty = faculty;
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }

        public void GetAction()
        {
            Random random = new Random();
            Console.WriteLine("Нужно ли сегодня будет переустанавливать Windows.....");
            var temp = random.Next(1,2);
            if(temp == 1)
            {
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Похоже придется переустанавливать.......");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            if(temp == 2)
            {
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Нет ?! Что за чудный день!!");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ReadKey();
            Console.Clear();
        }

    }
}
