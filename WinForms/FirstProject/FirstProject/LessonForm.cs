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
    public partial class LessonForm : Form
    {
        public Lesson lesson;
        public LessonForm(Lesson lesson)
        {
            InitializeComponent();

            this.lesson = lesson;

            //Initialize page content
            this.labelSubject.Text = lesson.subject.name;
            this.labelTopic.Text = lesson.topic;
            this.labelGroup.Text = lesson.pupil_group.group_name;

            tableLayoutPanelGroup1.Controls.Add(new Label(){ Text = "pupil",
                TextAlign = ContentAlignment.MiddleCenter }, 0, tableLayoutPanelGroup1.RowCount - 1);
            tableLayoutPanelGroup1.Controls.Add(new Label(){ Text = "present",
                TextAlign = ContentAlignment.MiddleCenter }, 1, tableLayoutPanelGroup1.RowCount - 1);
            tableLayoutPanelGroup1.Controls.Add(new Label(){ Text = "put marks",
                TextAlign = ContentAlignment.MiddleCenter }, 2, tableLayoutPanelGroup1.RowCount - 1);
            tableLayoutPanelGroup1.Controls.Add(new Label(){ Text = "add mark",
                TextAlign = ContentAlignment.MiddleCenter }, 3, tableLayoutPanelGroup1.RowCount - 1);
            tableLayoutPanelGroup1.Controls.Add(new Label(){ Text = "delete mark",
                TextAlign = ContentAlignment.MiddleCenter }, 4, tableLayoutPanelGroup1.RowCount - 1);

            foreach(var pupil in lesson.pupil_group.pupils)
            {
                tableLayoutPanelGroup1.RowCount += 1;
                tableLayoutPanelGroup1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));

                tableLayoutPanelGroup1.Controls.Add(new Label() { Text = pupil.Value.name,
                    TextAlign = ContentAlignment.MiddleCenter }, 0, tableLayoutPanelGroup1.RowCount - 1);

                tableLayoutPanelGroup1.Controls.Add(new CheckBox() { CheckAlign = ContentAlignment.MiddleCenter },
                    1, tableLayoutPanelGroup1.RowCount - 1);

                tableLayoutPanelGroup1.Controls.Add(new Label(), 2, tableLayoutPanelGroup1.RowCount - 1);
            }
            

            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            State.lessons.Add(lesson);
            XML<List<Lesson>>.Serialize(State.path + "lessons_new.xml", State.lessons);
        }

        private void LessonForm_Load(object sender, EventArgs e)
        {

        }

    }
}
