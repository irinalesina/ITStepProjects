using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;



namespace SchoolJournal
{
    static class XML<type>
    {
        public static void Serialize(string path, type obj)
        {
            // передаем в конструктор тип класса
            XmlSerializer writer = new XmlSerializer(typeof(type));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                writer.Serialize(fs, obj);

                Console.WriteLine("Объект {0} сериализован", obj.GetType());
            }
        }

        public static type Deserialize(string path)
        {
            XmlSerializer reader = new XmlSerializer(typeof(type));
            type take_obj;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                take_obj = (type)reader.Deserialize(fs);

                Console.WriteLine("Объект {0} десериализован", take_obj.GetType());
            }
            return take_obj;
        }
    }
}
