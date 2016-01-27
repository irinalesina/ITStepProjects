using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SchoolJournal
{
    [Serializable]
    public class PupilsGroup
    {
        public string group_name;
        public MySortedDictionary<int, Pupil> pupils;
        
        public PupilsGroup() 
        {
        }

        public PupilsGroup(string name) 
        {
            pupils = new  MySortedDictionary<int, Pupil>();

            this.group_name = name;
        }
    }
}
