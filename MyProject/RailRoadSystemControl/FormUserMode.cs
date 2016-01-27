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
    public partial class FormUserMode : Form
    {
        private FormHome parent;
        public FormUserMode(FormHome parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void FormUserMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void FormUserMode_Load(object sender, EventArgs e)
        {
            dateTimePickerDate.MinDate = DateTime.Now;
            try
            {
                foreach (var station in DBConnector.SelectStations())
                {
                    comboBoxStationFrom.Items.Add(station);
                    comboBoxStationTo.Items.Add(station);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            tableLayoutPanelSchedule.SuspendLayout();
            ClearSchedule();
            try
            {
                foreach (var scheduleStr in DBConnector.SelectSchedule(comboBoxStationFrom.Text, comboBoxStationTo.Text, dateTimePickerDate.Text))
                {
                    tableLayoutPanelSchedule.RowCount += 1;
                    tableLayoutPanelSchedule.RowStyles.Add(new RowStyle(SizeType.AutoSize));


                    tableLayoutPanelSchedule.Controls.Add(new Label()
                    {
                        Text = scheduleStr["train"],
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Times New Roman", 14.0f),
                        Dock = DockStyle.Fill
                    }, 0, tableLayoutPanelSchedule.RowCount - 1);

                    tableLayoutPanelSchedule.Controls.Add(new Label()
                    {
                        Text = scheduleStr["departureStation"] + " - " + scheduleStr["arrivalStation"],
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Times New Roman", 14.0f),
                        Dock = DockStyle.Fill
                    }, 1, tableLayoutPanelSchedule.RowCount - 1);

                    tableLayoutPanelSchedule.Controls.Add(new Label()
                    {
                        Text = scheduleStr["arrivalDateTime"],
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Times New Roman", 14.0f),
                        Dock = DockStyle.Fill
                    }, 2, tableLayoutPanelSchedule.RowCount - 1);

                    tableLayoutPanelSchedule.Controls.Add(new Label()
                    {
                        Text = scheduleStr["departureDateTime"],
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Times New Roman", 14.0f),
                        Dock = DockStyle.Fill
                    }, 3, tableLayoutPanelSchedule.RowCount - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            

            tableLayoutPanelSchedule.ResumeLayout();
        }

        public bool IsValid()
        {
            if (comboBoxStationFrom.Text == "" || comboBoxStationTo.Text == "")
                return false;
            return true;
        }

        public void ClearSchedule()
        {
            tableLayoutPanelSchedule.SuspendLayout();
            while (tableLayoutPanelSchedule.RowCount > 1)
            {
                int row = tableLayoutPanelSchedule.RowCount - 1;
                for (int i = 0; i < tableLayoutPanelSchedule.ColumnCount; i++)
                {
                    Control c = tableLayoutPanelSchedule.GetControlFromPosition(i, row);
                    tableLayoutPanelSchedule.Controls.Remove(c);
                    c.Dispose();
                }

                tableLayoutPanelSchedule.RowStyles.RemoveAt(row);
                tableLayoutPanelSchedule.RowCount--;
            }
            tableLayoutPanelSchedule.ResumeLayout();
            tableLayoutPanelSchedule.PerformLayout();
        }

        private void buttonShowMap_Click(object sender, EventArgs e)
        {
            FormMap formMap = new FormMap(this);
            formMap.Show();
            this.Hide();
        }
    }
}
