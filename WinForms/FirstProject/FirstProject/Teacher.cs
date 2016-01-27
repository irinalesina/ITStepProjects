using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SchoolJournal
{
    [Serializable]
    public class Teacher : Human
    {
        [XmlIgnore]
        public static int lastId=0;

        [XmlIgnore]
        public int teacherId;

        
        public int TeacherId
        {
            get
            {
                return teacherId;
            }
            set
            {
                lastId = value >= lastId ? value + 1 : lastId;
                teacherId = value;
            }
        }


        public string login;
        public string password;
        public int salary;
        public List<Subject> subjects;
        public string qualification;

        public Teacher(){
            teacherId = lastId++;
        }

        public Teacher(string name) : this()
        {

            this.name = name;
        }

        public Mark PutMark(Pupil pupil, String for_what, int value)
        {
            return new Mark(this, pupil, for_what, value);
        }


    }
}
