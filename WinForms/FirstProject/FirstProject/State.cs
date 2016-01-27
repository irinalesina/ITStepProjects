using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolJournal;

namespace FirstProject
{
    static class State
    {

        public static string path = "../../../SchoolJournal/SJ_INFO/";
        public static List<Teacher> teachers = XML<List<Teacher>>.Deserialize(path + "teachers.xml");
        public static Teacher currentUser;
        public static List<Lesson> lessons = XML<List<Lesson>>.Deserialize(path + "lessons_new.xml");

        public static List<TimeSpan> lessonStarts = new List<TimeSpan>();
        public static List<TimeSpan> lessonEnds = new List<TimeSpan>();

        static State()
        {
            // 1
            lessonStarts.Add(new TimeSpan(8, 30, 0));
            lessonEnds.Add(new TimeSpan(9, 15, 0));
            // 2
            lessonStarts.Add(new TimeSpan(9, 25, 0));
            lessonEnds.Add(new TimeSpan(10, 10, 0));
            // 3
            lessonStarts.Add(new TimeSpan(10, 20, 0));
            lessonEnds.Add(new TimeSpan(11, 05, 0));
            // 4
            lessonStarts.Add(new TimeSpan(11, 25, 0));
            lessonEnds.Add(new TimeSpan(12, 10, 0));
            // 5
            lessonStarts.Add(new TimeSpan(12, 20, 0));
            lessonEnds.Add(new TimeSpan(13, 05, 0));
        }
    }
       

}
