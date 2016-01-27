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
    public partial class FormAdmin : Form
    {
        FormHome parent;


        public FormAdmin(FormHome parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            FillFormAdmin();
        }

        public bool IsValid()
        {
            if (comboBoxRoute.Text == "" || comboBoxTrain.Text == "")
                return false;
            return true;
        }

        public void RefreshForm()
        {
            
            dateTimePickerDate.MinDate = DateTime.Now;
            dateTimePickerTime.Value = DateTime.Now;
            comboBoxRoute.SelectedIndex = -1;
            comboBoxTrain.SelectedIndex = -1;
            labelRouteStations.Text = "";
        }

        private void buttonAddRecordInSchedule_Click(object sender, EventArgs e)
        {
            if (!this.IsValid())
            {
                MessageBox.Show("Fill all the fields!");
                return;
            }

            SortedDictionary<string, string> record = new SortedDictionary<string, string>();
            record.Add("idTrain", comboBoxTrain.Text);
            record.Add("departureDateTime", dateTimePickerDate.Text + " " + dateTimePickerTime.Text);
            record.Add("idRoute", ((KeyValuePair<string, string>)comboBoxRoute.SelectedItem).Key);

            try
            {
                DBConnector.InsertRecordInSchedule(record);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            

            MessageBox.Show("New train was created!");
            this.RefreshForm();
        }

        private void comboBoxRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRoute.SelectedIndex == -1)
            {
                return;
            }
            labelRouteStations.Text = "";

            try
            {
                foreach (var station in DBConnector.SelectRouteStations(((KeyValuePair<string, string>)comboBoxRoute.SelectedItem).Key))
                {
                    labelRouteStations.Text += station + " - ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            

            labelRouteStations.Text = labelRouteStations.Text.Substring(0, labelRouteStations.Text.Length - 3);
        }

        private void buttonCreateRoute_Click(object sender, EventArgs e)
        {
            FormCreateRoute formCreateRoute = new FormCreateRoute(this);
            formCreateRoute.Show();
            this.Hide();
        }

        public void FillFormAdmin()
        {
            dateTimePickerDate.MinDate = DateTime.Now;
            dateTimePickerTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerTime.CustomFormat = "HH:mm";
            dateTimePickerTime.ShowUpDown = true;

            foreach (var train in DBConnector.SelectTrains())
            {
                comboBoxTrain.Items.Add(train);
            }

            comboBoxRoute.DataSource = new BindingSource(DBConnector.SelectRoutes(), null);
            comboBoxRoute.DisplayMember = "Value";
            comboBoxRoute.ValueMember = "Key";
            comboBoxRoute.SelectedIndex = -1;

            labelRouteStations.Text = "";
        }

        public void ReloadRoutes()
        {
            try
            {
                comboBoxRoute.DataSource = new BindingSource(DBConnector.SelectRoutes(), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            
            comboBoxRoute.DisplayMember = "Value";
            comboBoxRoute.ValueMember = "Key";
            comboBoxRoute.SelectedIndex = -1;
            labelRouteStations.Text = "";
        }

        public void ReloadTrains()
        {
            try
            {
                comboBoxTrain.DataSource = new BindingSource(DBConnector.SelectTrains(), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            //comboBoxTrain.DisplayMember = "Value";
            //comboBoxTrain.ValueMember = "Key";
            comboBoxTrain.SelectedIndex = -1;
        }

        private void buttonCreateTrain_Click(object sender, EventArgs e)
        {
            FormCreateTrain formCreateTrain = new FormCreateTrain(this);
            formCreateTrain.Show();
            this.Hide();
        }

    }
}
