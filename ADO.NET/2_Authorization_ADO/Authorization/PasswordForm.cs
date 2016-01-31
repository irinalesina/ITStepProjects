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

namespace Authorization
{
    public partial class PasswordForm : Form
    {
      
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           if(this.IsValid())
           {
               if(DBConnector.UpdatePassword(tbNewPas.Text, tbEmail.Text))
               {
                   MessageBox.Show("Password is changed!");
                   this.Close();
               }
               else
                   MessageBox.Show("Password is not changed! Try again!");
           }
           else
               MessageBox.Show("Data is not valid!");
        }

        public bool IsValid()
        {
            if (tbEmail.Text == "" || tbNewPas.Text == "" || tbNewPas.Text.Length < 6 || tbNewPas.Text != tbNewPas2.Text)
                return false;
            return true;
        }
    }
}
