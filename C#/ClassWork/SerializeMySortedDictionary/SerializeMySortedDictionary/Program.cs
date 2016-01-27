using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SerializeMySortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MySortedDictionary<char, List<string>> msd = new MySortedDictionary<char, List<string>>();

            for(int i = 65; i < 70; i++)
            {
                //string s = new string((char)i, 1);
                msd.Add(Convert.ToChar(i), new List<string>() { "Ab", "Bc", "Cd" });
            }

            foreach(var i in msd)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine();

            
           
            // Serialization

            //XmlTextWriter writer = new XmlTextWriter("test.xml", null);
            //XmlSerializer serializer = new XmlSerializer(typeof(MySortedDictionary<char, List<int>>));
            //serializer.Serialize(writer, msd);

            //StreamWriter sw = new StreamWriter("../../test.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(MySortedDictionary<char, List<string>>));
            //serializer.Serialize(sw, msd);

            Console.WriteLine("Serialization is finished!");

            // Deserialization

            //XmlReader reader = XmlReader.Create("../../test.xml");
            FileStream fs = new FileStream("../../test.xml", FileMode.Open);
            MySortedDictionary<char, List<string>> des_msd = (MySortedDictionary<char, List<string>>)serializer.Deserialize(fs);

            Console.ReadKey();
        }
    }
}
