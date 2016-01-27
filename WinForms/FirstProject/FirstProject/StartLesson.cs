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
    public partial class StartLesson : Form
    {
        public Lesson lesson;
        public StartLesson(Lesson lesson)
        {
            this.lesson = lesson;// curriculum
            InitializeComponent();

            for (int i = 0; i < State.lessonStarts.Count; i++)
            {
                comboBoxStartTime.Items.Add((i + 1).ToString() +
               ". " + State.lessonStarts[i]);
            }



            DateTime dateTime = DateTime.Now;
            var current_time = dateTime.TimeOfDay;

            int startIndex = 0;
            bool find = false;
            foreach(var lessonEnd in State.lessonEnds)
            {
                if (current_time.CompareTo(lessonEnd) == -1)
                {
                    comboBoxStartTime.SelectedIndex = startIndex;
                    find = true;
                    break;
                }
                startIndex++;
            }

            if(find == false)
            {
                comboBoxStartTime.SelectedIndex = State.lessonStarts.Count - 1;
            }

            

            labelTeacherName.Text = lesson.teacher.name;

            labelSubjectName.Text = lesson.subject.name;
            labelGroupName.Text = lesson.pupil_group.group_name;
            textBoxTopic.Text = lesson.topic;
        }

        private void StartLesson_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            LessonForm lessonForm = new LessonForm(lesson);
            this.lesson.Date = dateTimePickerLesson.Value.Date;
            this.lesson.topic = textBoxTopic.Text;
            this.lesson.lessonNumb = comboBoxStartTime.Text;
            lessonForm.ShowDialog(); 
        }


    }
}
