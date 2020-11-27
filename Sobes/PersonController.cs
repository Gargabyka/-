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
    }
}
