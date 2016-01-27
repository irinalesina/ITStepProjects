using System;
using System.Xml;
using System.Collections.Generic;


namespace _11_XML
{
    class MyApp
    {
        public static List<Automobile> automobiles = new List<Automobile>();

        static void displayNode(XmlNode node, int level = 0)
        {

            if (node.NodeType == XmlNodeType.Element)
            {
                Console.Write(new String(' ', level) + node.Name);
                foreach (XmlAttribute a in node.Attributes)
                {
                    Console.Write(" {0}='{1}'", a.Name, a.Value);
                }
                Console.WriteLine();
            }
            if (node.NodeType == XmlNodeType.Text)
            {
                Console.WriteLine(new String(' ', level) + '*' + node.Value + '*');
            }


            foreach (XmlNode child in node.ChildNodes)
            {
                displayNode(child, level + 1);
            }
        }


        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Cars.xml");
            XmlNode root = doc.ChildNodes[1];

            //displayNode(root);

            XmlNodeList nodes = root.ChildNodes;


            foreach (XmlNode node in nodes)
            {
                //automobiles.Add(new Automobile());
                if (node.Name != "Car" || node.NodeType != XmlNodeType.Element)
                {
                    continue;
                }

                try
                {
                    Automobile auto = new Automobile(node);
                    automobiles.Add(auto);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            int i = 1;
            foreach(var auto in automobiles)
            {
                Console.WriteLine(i++);
                auto.ShowInfo();
                Console.WriteLine();
            }

            Console.WriteLine();

            // find auto with min year
            Automobile new_auto = new Automobile();
            new_auto.year = 0;
            foreach (var auto in automobiles)
            {
                if(new_auto.year < auto.year)
                {
                    new_auto = auto;
                }
            }
            Console.WriteLine("New auto: ");
            new_auto.ShowInfo();


            Console.ReadLine();
        }

        
    }
}