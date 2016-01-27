using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace SchoolJournal
{
    [Serializable]
    public class Lesson
    {
        public Subject subject;
        public string topic;
        public Teacher teacher;
        public PupilsGroup pupil_group;
        public List<Mark> marks;

        public Lesson() { marks = new List<Mark>(); }

        public Lesson(Subject subject, string theme, Teacher teacher, PupilsGroup pupil_group)
        {
            this.subject = subject;
            this.topic = theme;
            this.teacher = teacher;
            this.pupil_group = pupil_group;
            marks = new List<Mark>();
        }

        public void ManageLesson()
        {
            Console.WriteLine("Lesson is begins!");

            marks.Add(teacher.PutMark(pupil_group.pupils[0], "home work", 10));
            marks.Add(teacher.PutMark(pupil_group.pupils[1], "class work", 10));
            marks.Add(teacher.PutMark(pupil_group.pupils[2], "good actions", 10));
            marks.Add(teacher.PutMark(pupil_group.pupils[3], "home work", 10));

            foreach(var mark in marks)
            {
                mark.Show();
            }

            Console.WriteLine("Lesson is finished!");
        }

        public void RepeatLesson()
        {
            Console.WriteLine("Lesson is begins!");

            foreach (var mark in marks)
            {
                mark.Show();
            }

            Console.WriteLine("Lesson is finished!");
        }

        
    }
}
