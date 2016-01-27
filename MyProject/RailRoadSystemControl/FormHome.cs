using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TrainControlSystem
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin(this);
            formAdmin.Show();
            this.Hide();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            FormSchedule formSchedule = new FormSchedule(this);
            formSchedule.Show();
            this.Hide();
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBConnector.CloseConnection();
        }

        private void buttonUser_Click_1(object sender, EventArgs e)
        {
            FormUserMode formUserMode = new FormUserMode(this);
            formUserMode.Show();
            this.Hide();
        }
    }
}
