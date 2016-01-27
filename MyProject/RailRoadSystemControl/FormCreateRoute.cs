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
    public partial class FormCreateRoute : Form
    {
        FormAdmin parent;
        public FormCreateRoute(FormAdmin parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormCreateRoute_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxSelectedStation.DataSource = new BindingSource(DBConnector.SelectStationsWithId(), null);
                comboBoxSelectedStation.DisplayMember = "Key";
                comboBoxSelectedStation.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            

            RefreshFormAddStation();
        }

        public void RefreshFormAddStation()
        {
            dateTimePickerArrivalTime.Value = DateTime.Now;
            dateTimePickerDepartureTime.Value = DateTime.Now;
            comboBoxSelectedStation.SelectedIndex = -1;
        }

        private void FormCreateRoute_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectedStation.SelectedIndex == -1)
            {
                MessageBox.Show("Select station!");
                return;
            }
            

            tableLayoutPanelSelectedRoute.SuspendLayout();

            tableLayoutPanelSelectedRoute.Controls.Add(new Label()
            {
                Text = ((KeyValuePair<string, string>)comboBoxSelectedStation.SelectedItem).Key,
                Tag = ((KeyValuePair<string, string>)comboBoxSelectedStation.SelectedItem).Value,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Times New Roman", 14.0f),
                Dock = DockStyle.Fill
            }, 0, tableLayoutPanelSelectedRoute.RowCount - 1);

            tableLayoutPanelSelectedRoute.Controls.Add(new Label()
            {
                Text = dateTimePickerArrivalTime.Text,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Times New Roman", 14.0f),
                Dock = DockStyle.Fill
            }, 1, tableLayoutPanelSelectedRoute.RowCount - 1);

            tableLayoutPanelSelectedRoute.Controls.Add(new Label()
            {
                Text = dateTimePickerDepartureTime.Text,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Times New Roman", 14.0f),
                Dock = DockStyle.Fill
            }, 2, tableLayoutPanelSelectedRoute.RowCount - 1);

            //tableLayoutPanelSelectedRoute.Controls.Add(new CheckBox()
            //{
            //    CheckAlign = ContentAlignment.MiddleCenter,
            //    Dock = DockStyle.Fill
            //}, 3, tableLayoutPanelSelectedRoute.RowCount - 1);


            tableLayoutPanelSelectedRoute.RowCount += 1;
            tableLayoutPanelSelectedRoute.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            tableLayoutPanelSelectedRoute.ResumeLayout();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxRouteName.Text == "")
            {
                MessageBox.Show("Enter routr name!");
                return;
            }

            List<Dictionary<string, string>> route = new List<Dictionary<string, string>>();

            tableLayoutPanelSelectedRoute.SuspendLayout();

            while (tableLayoutPanelSelectedRoute.RowCount > 1)
            {
                Dictionary<string, string> routeStation = new Dictionary<string, string>();
                routeStation.Add("routeName", textBoxRouteName.Text);

                int row = tableLayoutPanelSelectedRoute.RowCount - 2;
                for (int i = 0; i < tableLayoutPanelSelectedRoute.ColumnCount; i++)
                {
                    Control c = tableLayoutPanelSelectedRoute.GetControlFromPosition(i, row);
                    if (i == 0)
                    {
                        routeStation.Add("idStation", c.Tag.ToString());
                    }
                    else if (i == 1)
                    {
                        routeStation.Add("arrivalTime", c.Text);
                    }
                    else if (i == 2)
                    {
                        routeStation.Add("departureTime", c.Text);
                    }

                    tableLayoutPanelSelectedRoute.Controls.Remove(c);
                    c.Dispose();
                }
                route.Add(routeStation);

                if (tableLayoutPanelSelectedRoute.RowCount != 1)
                {
                    tableLayoutPanelSelectedRoute.RowStyles.RemoveAt(row);
                    tableLayoutPanelSelectedRoute.RowCount--;
                }
            }

            try
            {
                DBConnector.InsertRoute(route);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            
            MessageBox.Show("New route was created!");
            tableLayoutPanelSelectedRoute.ResumeLayout();
            //var comboBoxRoute = parent.Controls.Find("comboBoxRoute", true).FirstOrDefault() as ComboBox;
            this.parent.ReloadRoutes();
        }

    }
}
