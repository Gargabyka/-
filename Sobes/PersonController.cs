using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Sobes
{
    public class PersonController
    {
        public List<Person> personList;

        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("person.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, personList);
            }
        }

        public List<Person> Load()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("person.dat", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0 && formatter.Deserialize(fs) is List<Person> personList)
                {
                    Console.WriteLine("Пользователи успешно загружены");
                    return personList;
                }

                else
                {
                    Console.WriteLine("Ошибка, создание нового списка пользователей");
                    return new List<Person>();
                }
            }

        }
    }
}
