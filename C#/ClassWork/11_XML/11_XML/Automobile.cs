using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace _11_XML
{
    class Automobile
    {
        public string manufactured, model, color;
        public int year, speed;
        public Automobile auto;

        public Automobile() { }
        public Automobile(XmlNode node)
        {
            manufactured = GetNodeElement(node, "Manufactured");
            model = GetNodeElement(node, "Model");
            color = GetNodeElement(node, "Color");
            speed = Convert.ToInt32(GetNodeElement(node, "Speed"));
            year = Convert.ToInt32(GetNodeElement(node, "Year"));
            if(node["Inside"] != null)
            {
                auto = new Automobile(node["Inside"]["Car"]);
            }
        }

        public static string GetNodeElement(XmlNode node, string element)
        {
            if (node[element] != null)
            {
                return node[element].InnerText;
            }
            if (node.Attributes[element] != null)
            {
                return node.Attributes[element].InnerText;
            }
            else
            {
                string message = string.Format("{0} does not exist!", element);
                throw new ArgumentException(message);
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Manufacture: {0}", manufactured);
            Console.WriteLine("Model: {0}", model);
            Console.WriteLine("Color: {0}", color);
            Console.WriteLine("Year: {0}", year);
            Console.WriteLine("Speed: {0}", speed);
            if(auto != null)
            {
                Console.WriteLine("    Auto inside:");
                auto.ShowInfo();
            }
        }

        



    }
}
