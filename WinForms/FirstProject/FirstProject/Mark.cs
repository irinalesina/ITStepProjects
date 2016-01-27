using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SchoolJournal
{
    [Serializable]
    public class Mark
    {
        [XmlIgnore] public Pupil pupil;
        [XmlAttribute] public int pupilId;
        [XmlIgnore] public Teacher teacher;
        [XmlAttribute] public int teacherId;


        public int value;

        public string for_what; // replace enum

        public Mark() { }

        public Mark(Teacher teacher, Pupil pupil, string for_what, int value)
        {
            this.teacher = teacher;
            this.pupil = pupil;
            this.for_what = for_what;
            this.value = value;
            this.teacherId = teacher.teacherId;
            this.pupilId = pupil.pupilId;
        }

        public void Show()
        {
            Console.WriteLine("{0} take {1} for {2}.", pupil.name, value, for_what);
        }

    }
}
