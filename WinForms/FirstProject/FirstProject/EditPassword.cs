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
    public partial class EditPassword : Form
    {
        public EditPassword()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            State.currentUser.password = textBoxNewPassword.Text;
            XML<List<Teacher>>.Serialize(State.path + "teachers.xml", State.teachers);
            this.Hide();
        }
    }
}
