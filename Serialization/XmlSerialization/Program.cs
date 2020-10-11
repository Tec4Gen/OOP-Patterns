using Entities;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace BynarySerialization
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlSerializer formatter = new XmlSerializer(typeof(User));

            using (FileStream fs = new FileStream("user.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, new User 
                {
                    FirstName = "Oleg",
                    LastName = "Ivanov",
                    MiddleName = "Alekseevich",
                    Age = 20
                });

                Console.WriteLine("Объект сериализован");
            }

            using (FileStream fs = new FileStream("user.xml", FileMode.OpenOrCreate))
            {
                var User = (User)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");

                Console.WriteLine($"Имя: {User.FirstName}  {User.LastName} {User.MiddleName} Возраст: {User.Age}");
            }
        }
    }
}
