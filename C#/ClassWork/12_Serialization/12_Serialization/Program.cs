using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil = new Pupil("Kolya", 23);
            pupil.things.Add("blue pen");
            pupil.things.Add("red pen");
            pupil.marks[0] = 5;
            pupil.XmlSerialization();
            pupil.BinarySerialization();

            Pupil des_pupil = Pupil.XMLDeserialization("pupil.xml");

            des_pupil.Show();

            Console.ReadLine();
        }
    }
}
