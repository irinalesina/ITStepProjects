using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _12_Serialization
{
    [Serializable]
    public class Pupil
    {
        public string name;
        public List<string> things;
        public int age;
        public int[] marks;

        public Pupil()
        {
            things = new List<string>();
        }

        public Pupil(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.marks = new int[1];
            things = new List<string>();
            // объект для сериализации
            Console.WriteLine("Объект создан");
        }

        public void Show()
        {
            Console.WriteLine("name: {0}", name);
            Console.WriteLine("age: {0}", age);
            Console.WriteLine("things: ");
            foreach(var th in things)
            {
                Console.WriteLine("  {0}", th);
            }
        }


        public void XmlSerialization()
        {
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(Pupil));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("pupil.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this);

                Console.WriteLine("Объект xml сериализован");
            }
        }


        public static Pupil XMLDeserialization(string file_name)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Pupil));
            // десериализация
            using (FileStream fs = new FileStream(file_name, FileMode.OpenOrCreate))
            {
                Pupil pupil = (Pupil)formatter.Deserialize(fs);

                Console.WriteLine("Объект xml десериализован");

                return pupil;
            }
        }


        public void BinarySerialization()
        {
            // передаем в конструктор тип класса
             BinaryFormatter formatter = new BinaryFormatter();

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("pupil.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this);

                Console.WriteLine("Объект бинарно сериализован");
            }
        }

    }
}
