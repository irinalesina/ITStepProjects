using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace _7_LINQ
{
    public class CD
    {
        [DisplayName("Название альбома")]
        public string TITLE { get; set; }

        [DisplayName("Артист")]
        public string ARTIST { get; set; }

        [DisplayName("Страна")]
        public string COUNTRY { get; set; }

        [DisplayName("Компания")]
        public string COMPANY { get; set; }

        [DisplayName("Цена")]
        public decimal PRICE { get; set; }

        [DisplayName("Год")]
        public int YEAR { get; set; }

        [DisplayName("Продьюсер")]
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
