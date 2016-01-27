using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolJournal;



namespace FirstProject
{
    public partial class FormСonductedLessons : Form
    {
        public FormСonductedLessons()
        {
            InitializeComponent();


            foreach(var lesson in State.lessons)
            {
                comboBoxSubject.Items.Add(lesson.subject.name);
            }
            

        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lessonsQuery =
                from lesson in State.lessons
                where lesson.subject.name == comboBoxSubject.Text
                select lesson;


            foreach(var lesson in lessonsQuery)
            {
                dataGridViewInfo.Rows.Add(lesson.Date, lesson.lessonNumb, lesson.pupil_group.group_name, lesson.topic);
            }
        }
    }
}
