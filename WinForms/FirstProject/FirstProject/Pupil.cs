using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SchoolJournal
{
    [Serializable]
    public class Pupil : Human
    {
        [XmlIgnore]
        public static int lastId = 0;

        [XmlIgnore]
        public int pupilId;

        
        public int PupilId
        {
            get
            {
                return pupilId;
            }
            set
            {
                lastId = value >= lastId ? value + 1 : lastId;
                pupilId = value;
            }
        }


        public string parent_info;
        public Pupil() 
        {
            pupilId = lastId++;
        }

        public Pupil(string name) : this()
        {
            this.name = name;
        }

        
    }
}
