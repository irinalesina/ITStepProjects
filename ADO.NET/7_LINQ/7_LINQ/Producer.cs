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
    public class PRODUCER
    {
        [DisplayName("ID")]
        public int ID { get; set; }

        [DisplayName("Имя")]
        public string NAME { get; set; }

        [DisplayName("Дата получения прибыли")]
        public DateTime DATE { get; set; }

        [DisplayName("Прибыль")]
        public int FEE { get; set; }

        public PRODUCER() { }

        public static List<PRODUCER> GetProducersFromXML()
        {
            List<PRODUCER> producers = new List<PRODUCER>();

            XmlSerializer formatter = new XmlSerializer(typeof(List<PRODUCER>));
            using (FileStream fs = new FileStream("../../cd_catalog _2.xml", FileMode.OpenOrCreate))
            {
                producers = (List<PRODUCER>)formatter.Deserialize(fs);

            }

            return producers;
        }
    }
}
