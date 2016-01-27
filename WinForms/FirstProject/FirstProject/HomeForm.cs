using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolJournal;

namespace FirstProject
{
    public partial class HomeForm : Form
    {
        System.Windows.Forms.Timer timer;
        Login parent;
        public HomeForm(Login parent)
        {
            this.parent = parent;
            InitializeComponent();
            labelDateTime.Text = DateTime.Now.ToString();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler((obj, e) => labelDateTime.Text = DateTime.Now.ToString());
            timer.Enabled = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditPassword editPassword = new EditPassword();
            editPassword.Show();
        }

        private void buttonStartLesson_Click(object sender, EventArgs e)
        {
            Lesson new_lesson = new Lesson();
            new_lesson.subject = new Subject("Mathematics");
            new_lesson.topic = "topic 1";

            Pupil pupil1 = new Pupil("Tim");
            Pupil pupil2 = new Pupil("Alex");
            Pupil pupil3 = new Pupil("Jon");
            Pupil pupil4 = new Pupil("Cindy");

            new_lesson.pupil_group = new PupilsGroup("Group 1");
            new_lesson.pupil_group.pupils.Add(pupil1.pupilId, pupil1);
            new_lesson.pupil_group.pupils.Add(pupil2.pupilId, pupil2);
            new_lesson.pupil_group.pupils.Add(pupil3.pupilId, pupil3);
            new_lesson.pupil_group.pupils.Add(pupil4.pupilId, pupil4);

            new_lesson.teacher = State.teachers[0];
            

            StartLesson startLesson = new StartLesson(new_lesson);
            startLesson.Show();
        }

        private void buttonСonductedLessons_Click(object sender, EventArgs e)
        {
            FormСonductedLessons conductedLessons = new FormСonductedLessons();
            conductedLessons.Show();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var answer = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
                
            }
            else
            {
                parent.Show();
            }
        }


    }
}
