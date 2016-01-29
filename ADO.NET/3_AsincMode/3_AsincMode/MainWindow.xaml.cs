using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3_AsincMode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection;

        public MainWindow()
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            InitializeComponent();
        }

        async private void btnOrders_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await connection.OpenAsync();

                SqlCommand cmdSelect = connection.CreateCommand();
                cmdSelect.CommandText = "SELECT * FROM Customers";

                SqlDataReader reader = await cmdSelect.ExecuteReaderAsync();

                listInfo.Items.Add("Данные получены в асинхронном режиме");
                while (await reader.ReadAsync())
                {
                    String info = String.Format("{0} {1} {2} {3} {4} {5}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                    listInfo.Items.Add(info);
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }
    }
}
