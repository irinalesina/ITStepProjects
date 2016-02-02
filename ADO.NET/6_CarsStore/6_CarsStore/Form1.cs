using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_CarsStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBAutoDataSet.TMotor' table. You can move, or remove it, as needed.
            this.tMotorTableAdapter.Fill(this.dBAutoDataSet.TMotor);
            // TODO: This line of code loads data into the 'dBAutoDataSet.TOwner' table. You can move, or remove it, as needed.
            this.tOwnerTableAdapter.Fill(this.dBAutoDataSet.TOwner);
            // TODO: This line of code loads data into the 'dBAutoDataSet.TAuto' table. You can move, or remove it, as needed.
            this.tAutoTableAdapter.Fill(this.dBAutoDataSet.TAuto);
            // TODO: This line of code loads data into the 'dBAutoDataSet.TOwner' table. You can move, or remove it, as needed.
            this.tOwnerTableAdapter.Fill(this.dBAutoDataSet.TOwner);
            // TODO: This line of code loads data into the 'dBAutoDataSet.TMotor' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dBAutoDataSet.TAuto' table. You can move, or remove it, as needed.
            this.tAutoTableAdapter.Fill(this.dBAutoDataSet.TAuto);

        }

        async private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = @"Data Source=(localdb)\v11.0;AttachDbFilename=D:\ITStepProjects\ADO.NET\6_CarsStore\6_CarsStore\DBAuto.mdf;Integrated Security=True";
                await connection.OpenAsync();

                SqlCommand cmdSelect = connection.CreateCommand();
                cmdSelect.CommandText = "SELECT * FROM TMotor WHERE IDD=@IDD";
                string IDD = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                cmdSelect.Parameters.AddWithValue("@IDD", IDD);

                SqlDataReader reader = await cmdSelect.ExecuteReaderAsync();
                
                await reader.ReadAsync();
                iDDTextBox.Text = reader[0].ToString();
                markaTextBox.Text = reader[1].ToString();
                mTextBox.Text = reader[2].ToString();
                countryTextBox.Text = reader[3].ToString();
                dateTextBox1.Text = reader[4].ToString();

            }
            finally
            {
                connection.Close();
            }
        }
    }
}
