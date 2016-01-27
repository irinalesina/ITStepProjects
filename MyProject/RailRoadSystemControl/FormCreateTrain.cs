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
    public partial class FormCreateTrain : Form
    {
        FormAdmin parent;
        public FormCreateTrain(FormAdmin parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormCreateTrain_Load(object sender, EventArgs e)
        {
            try
            {
                listBoxTrain.DisplayMember = "Key";
                listBoxTrain.ValueMember = "Value";

                //fill listBoxWagonTypes
                listBoxWagonTypes.BeginUpdate();

                
                listBoxWagonTypes.DataSource = new BindingSource(DBConnector.SelectWagons(), null);
                
                listBoxWagonTypes.DisplayMember = "Key";
                listBoxWagonTypes.ValueMember = "Value";

                
                listBoxWagonTypes.EndUpdate();
                this.RefreshForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

        }

        private void FormCreateTrain_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void listBoxWagonTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWagonTypes.SelectedIndex >= 0)
            {
                listBoxTrain.Items.Add((KeyValuePair<string, string>)listBoxWagonTypes.SelectedItem);
                listBoxTrain.SelectedIndex = -1;
            }
        }

        public void RefreshForm()
        {
            textBoxTrainNumber.Text = "";
            listBoxTrain.Items.Clear();
            listBoxWagonTypes.SelectedIndex = -1;
            listBoxTrain.SelectedIndex = -1;
        }

        private void listBoxTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxTrain.SelectedIndex >= 0)
            {
                listBoxTrain.Items.Remove(listBoxTrain.SelectedItem);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(DBConnector.TrainIdIsFound(textBoxTrainNumber.Text))
                {
                    MessageBox.Show("This train name already exists!");
                    return;
                }

                List<string> wagons = new List<string>();

                for(int i = 0; i < listBoxTrain.Items.Count; i++)
                {
                    wagons.Add(((KeyValuePair<string, string>)listBoxTrain.Items[i]).Value);
                }

                DBConnector.InsertTrain(textBoxTrainNumber.Text, wagons);
                MessageBox.Show("New train was created!");

                parent.ReloadTrains();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            this.RefreshForm();
        }

    }
}
