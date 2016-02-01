using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
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
        public static List<Customer> customers = new List<Customer>();
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
                pbProgress.IsIndeterminate = true;
                await connection.OpenAsync();

                SqlCommand cmdSelect = connection.CreateCommand();
                cmdSelect.CommandText = "WAITFOR DELAY '0:0:05' SELECT Customers.CompanyName, Customers.ContactName, Customers.Address, Customers.City, Customers.Country, Customers.Phone, "
                +"Orders.OrderDate, Orders.ShippedDate, Orders.Freight, Orders.ShipCity, Orders.ShipCountry, Orders.ShipRegion, "
                +"[Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount "
                +"FROM Orders INNER JOIN Customers ON Orders.CustomerID=Customers.CustomerID INNER JOIN [Order Details] ON Orders.OrderID=[Order Details].OrderID";

                SqlDataReader reader = await cmdSelect.ExecuteReaderAsync();
                List<Order> orders = new List<Order>();
                
                while (await reader.ReadAsync())
                {
                    Customer currentCustomer = new Customer() { CompanyName=reader[0].ToString(), ContactName=reader[1].ToString(), Address=reader[2].ToString(), 
                        City=reader[3].ToString(), Country=reader[4].ToString(), Phone=reader[5].ToString() };
                    OrderInfo currentOrderInfo = new OrderInfo() { UnitPrice=reader[12].ToString(), Quantity=reader[13].ToString(), Discount=reader[14].ToString() };
                    Order order = new Order() { OrderDate=reader[6].ToString(), ShippedDate=reader[7].ToString(), Freight=reader[8].ToString(), 
                        ShipCity=reader[9].ToString(), ShipCountry=reader[10].ToString(), ShipRegion=reader[11].ToString(), customer=currentCustomer, orderInfo=currentOrderInfo };
                    orders.Add(order);
                }
                dgClientsOrders.ItemsSource = orders;
                pbProgress.IsIndeterminate = false;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }
    }
}
