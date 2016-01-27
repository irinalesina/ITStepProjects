using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SchoolJournal
{
    class Program
    {
        private static string path = "../../SJ_INFO/"; 

        static void Main(string[] args)
        {
            List<Teacher> teachers = new List<Teacher>();

            Teacher Max = new Teacher("Max");
            Max.login = "Max";
            Max.password = "Max";
            teachers.Add(Max);

            Pupil pupil1 = new Pupil("Andrew");
            Pupil pupil2 = new Pupil("Kolya");
            Pupil pupil3 = new Pupil("Olya");
            Pupil pupil4 = new Pupil("Ira");

            PupilsGroup pupils_group1 = new PupilsGroup("P11014");
            pupils_group1.pupils.Add(pupil1.pupilId, pupil1);
            pupils_group1.pupils.Add(pupil2.pupilId, pupil2);
            pupils_group1.pupils.Add(pupil3.pupilId, pupil3);
            pupils_group1.pupils.Add(pupil4.pupilId, pupil4);

            Subject subject = new Subject("C#");
            subject.topics.Add("Binary and xml serializations");
            subject.topics.Add("Global project");


            Lesson lesson1 = new Lesson(subject, subject.topics[0], Max, pupils_group1);
            lesson1.ManageLesson();

            
            Teacher Alex = new Teacher("Alex");
            Alex.login = "Alex";
            Alex.password = "Alex";
            teachers.Add(Alex);

            Pupil pupil11 = new Pupil("Jon");
            Pupil pupil22 = new Pupil("Brad");
            Pupil pupil33 = new Pupil("Josh");
            Pupil pupil44 = new Pupil("Katrin");

            PupilsGroup pupils_group2 = new PupilsGroup("P11015");
            pupils_group2.pupils.Add(pupil11.pupilId, pupil11);
            pupils_group2.pupils.Add(pupil22.pupilId, pupil22);
            pupils_group2.pupils.Add(pupil33.pupilId, pupil33);
            pupils_group2.pupils.Add(pupil44.pupilId, pupil44);



            Lesson lesson2 = new Lesson(subject, subject.topics[0], Alex, pupils_group2);
            //lesson2.ManageLesson();


            List<Lesson> lessons = new List<Lesson>();
            lessons.Add(lesson1);
            lessons.Add(lesson2);


            XML<PupilsGroup>.Serialize(path + "pupil_group1.xml", pupils_group1);

            XML<List<Lesson>>.Serialize(path + "lesson.xml", lessons);

            XML<List<Teacher>>.Serialize(path + "teachers.xml", teachers);

            // десериализация
            List<Lesson> des_lessons = XML<List<Lesson>>.Deserialize(path + "lesson.xml");


            Console.ReadLine();
        } 
    }
}
