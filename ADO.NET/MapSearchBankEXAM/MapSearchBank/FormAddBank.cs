using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapSearchBank
{
    public partial class FormAddBank : Form
    {
        FormAddDepartment parent;
        public FormAddBank(FormAddDepartment parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.IsValid())
            {
                Program.banksSystem.Bank.Add(new Bank() { Name = textBoxBankName.Text });
                Program.banksSystem.SaveChanges();
                MessageBox.Show("Bank is added!");
                parent.UpdateBanksList();
                this.Close();
            }
        }

        private bool IsValid()
        {
            if (textBoxBankName.Text == "")
            {
                MessageBox.Show("Enter bank name!");
                return false;
            }
               
            if ((from bank in Program.banksSystem.Bank where bank.Name == textBoxBankName.Text select bank).ToList().Count() > 0)
            {
                MessageBox.Show("Bank was find!");
                return false;
            }
            
            return true;
        }
    }
}
