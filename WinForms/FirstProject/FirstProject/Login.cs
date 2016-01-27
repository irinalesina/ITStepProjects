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

namespace FirstProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            
            foreach(var teacher in State.teachers)
            {
                if(login == teacher.login)
                {
                    if(password == teacher.password)
                    {
                        HomeForm home = new HomeForm(this);

                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));

                        home.Text = String.Format(resources.GetString("$this.Text", Thread.CurrentThread.CurrentUICulture), login);
                        home.Show();
                        State.currentUser = teacher;
                        this.textBoxPassword.Clear();
                        this.Hide();

                        return;
                    }
                    else
                    {
                        textBoxPassword.Clear();
                        MessageBox.Show("You enter invalid password!");
                        return;
                    }
                }
            }

            textBoxLogin.Clear();
            textBoxPassword.Clear();
            MessageBox.Show("User not found!");
        }


        private void textBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                buttonSubmit.Focus();
            }
        }
    }
}
