using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolJournal
{
    [Serializable]
    public class Subject
    {
        public string name;
        public List<string> topics;

        public Subject() { }

        public Subject(string name)
        {
            this.name = name;
            topics = new List<string>();
        }
    }
}
