using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authorization
{
    public partial class RegistrForm : Form
    {
        private Form parent;
     
        public RegistrForm(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
         
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(this.IsValid())
            {
                if(DBConnector.FindLogin(tbLogin.Text))
                {
                    MessageBox.Show("This login is occupied!");
                }
                else
                {
                    if (DBConnector.AddUser(tbLogin.Text, tbPas.Text, tbEmail.Text, tbName.Text, tbSurName.Text))
                    {
                        MessageBox.Show("New user created!");
                        MainForm mf = new MainForm(this);
                        mf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("New user is not created! Try again!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Check your data!");
            }
        }

        private bool IsValid()
        {
            if (tbLogin.Text == "" || tbPas.Text == "" || tbPas.Text.Length < 6 || tbPas.Text != tbPas2.Text || tbEmail.Text == "")
                return false;
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
