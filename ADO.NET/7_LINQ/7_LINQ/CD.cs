using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace _7_LINQ
{
    public class CD
    {
        public string TITLE { get; set; }
        public string ARTIST { get; set; }
        public string COUNTRY { get; set; }
        public string COMPANY { get; set; }
        public decimal PRICE { get; set; }
        public int YEAR { get; set; }
        public int PRODUCER { get; set; }

        public CD() { }

        public static List<CD> GetCdsFromXML()
        {
            List<CD> CDs = new List<CD>();

            XmlSerializer formatter = new XmlSerializer(typeof(List<CD>));
            using (FileStream fs = new FileStream("../../cd_catalog _1.xml", FileMode.OpenOrCreate))
            {
                CDs = (List<CD>)formatter.Deserialize(fs);

            }

            return CDs;
        }

    }
}
