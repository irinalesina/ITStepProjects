using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace TrainControlSystem
{
    public partial class FormSchedule : Form
    {
        FormHome parent;
        System.Windows.Forms.Timer timer;

        public FormSchedule(FormHome parent)
        {
            InitializeComponent();
            this.parent = parent;
        }


        private void FormUser_Load(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler((obj, ev) => labelDateTime.Text = DateTime.Now.ToString());
            timer.Enabled = true;
 

            foreach (var station in DBConnector.SelectStations())
            {
                comboBoxStations.Items.Add(station);
            }
        }


        private void FormUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }


        private void FillTimetable(string selectedStation)
        {
            List<Dictionary<string, string>> schedule = new List<Dictionary<string, string>>();
            try
            {
                schedule = DBConnector.SelectSchedule(selectedStation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            

            tableLayoutPanelSchedule.SuspendLayout();

            foreach (var scheduleStr in schedule)
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

            tableLayoutPanelSchedule.ResumeLayout();
        }

        private void comboBoxStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            lableStation.Text = comboBoxStations.Text;
            comboBoxStations.Hide();
            FillTimetable(comboBoxStations.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tableLayoutPanelSchedule.SuspendLayout();
            //play sound
            SoundPlayer simpleSound = new SoundPlayer(@"..\..\Resources\railwayStationSound.wav");
            simpleSound.Play();

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

            FillTimetable(lableStation.Text);
        }

    }
}
