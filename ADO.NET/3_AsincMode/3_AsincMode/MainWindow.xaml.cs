using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
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
                pbProgress.IsIndeterminate = true;
                await connection.OpenAsync();

                SqlCommand cmdSelect = connection.CreateCommand();
                cmdSelect.CommandText = "WAITFOR DELAY '0:0:02' SELECT Customers.CompanyName, Customers.ContactName, Customers.Address, Customers.City, Customers.Country, Customers.Phone, "
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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                pbProgress.IsIndeterminate = false;
            }
        }

        async private void btnEmployees_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pbProgress.IsIndeterminate = true;
                await connection.OpenAsync();

                SqlCommand cmdSelect = connection.CreateCommand();
                cmdSelect.CommandText = "SELECT FirstName, LastName, BirthDate, Address, HomePhone, Photo FROM Employees";

                SqlDataReader reader = await cmdSelect.ExecuteReaderAsync();
                List<Employee> employees = new List<Employee>();
                while (await reader.ReadAsync())
                {
                    Employee employee = new Employee() { FirstName=reader[0].ToString(), LastName=reader[1].ToString(),
                                                         Birthday = reader[2].ToString(),
                                                         Address = reader[3].ToString(),
                                                         Phone = reader[4].ToString(), 
                                                         Photo = BytesToImageSourse((byte[])reader[5])
                    };
                    employees.Add(employee);
                }
                lbEmployees.ItemsSource = employees;
                
            }
            catch (Exception ex)
            {
                throw ex;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                pbProgress.IsIndeterminate = false;
            }
        }

        public static ImageSource BytesToImageSourse(byte[] mb)
        {
            // формирование массива для хранения преобразованного массива
            byte[] arr = new byte[mb.Length - 78];
            // копирование массива, прочитанного из базы, во временный массив 
            // т.к. в базе данных фото хранится в виде Image (Ole bytes)
            // необходимо пропустить 78 байт с начала и не получать 78 байтов с конца
            Array.Copy(mb, 78, arr, 0, mb.Length - 78);

            BitmapImage bi = new BitmapImage();
            MemoryStream ms = new MemoryStream(arr);
            bi.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            bi.StreamSource = ms;
            bi.EndInit();
            return bi;
        }

        async private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pbProgress.IsIndeterminate = true;
                await connection.OpenAsync();

                SqlCommand cmdSelect = connection.CreateCommand();
                cmdSelect.CommandText = "SELECT ProductName, UnitPrice, Discontinued, QuantityPerUnit, CategoryName "+ 
                "FROM Products INNER JOIN Categories ON Products.CategoryID=Categories.CategoryID";

                SqlDataReader reader = await cmdSelect.ExecuteReaderAsync();
                List<Product> products = new List<Product>();
                while (await reader.ReadAsync())
                {
                    Product prod = new Product()
                    {
                        ProductName = reader[0].ToString(),
                        UnitPrice = reader[1].ToString(),
                        Discontinued = reader[2].ToString(),
                        QuantityPerUnit = reader[3].ToString(),
                        CategoryName = reader[4].ToString()
                    };
                    products.Add(prod);
                }
                dgProducts.ItemsSource = products;
            }
            catch (Exception ex)
            {
                throw ex;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                pbProgress.IsIndeterminate = false;
            }
        }

        async private void btnClientsInCity_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pbProgress.IsIndeterminate = true;
                await connection.OpenAsync();

                SqlCommand cmdSelect = connection.CreateCommand();
                cmdSelect.CommandText = "SELECT City, COUNT(*) FROM Customers GROUP BY City";

                SqlDataReader reader = await cmdSelect.ExecuteReaderAsync();
                List<ClientsInCity> customersInCity = new List<ClientsInCity>();
                while (await reader.ReadAsync())
                {
                    ClientsInCity c = new ClientsInCity()
                    {
                        City = reader[0].ToString(),
                        ClientsCount = reader[1].ToString()
                    };
                    customersInCity.Add(c);
                }
                dgClientsInCity.ItemsSource = customersInCity;
            }
            catch (Exception ex)
            {
                throw ex;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                pbProgress.IsIndeterminate = false;
            }
        }

        async private void btnClientsInfo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pbProgress.IsIndeterminate = true;
                await connection.OpenAsync();

                SqlCommand cmdSelect = connection.CreateCommand();
                cmdSelect.CommandText = "SELECT Customers.ContactName, Customers.CompanyName, Customers.City, Customers.Country, Groups.OrdersSum "+
                    "FROM Customers INNER JOIN (SELECT CustomerID, SUM([Order Details].UnitPrice*(1+Discount)*Quantity) as OrdersSum "+
                    "FROM Orders INNER JOIN [Order Details] ON Orders.OrderID=[Order Details].OrderID WHERE Orders.OrderDate BETWEEN @from AND @to "+
                    "GROUP BY CustomerID) as Groups ON Customers.CustomerID=Groups.CustomerID";
                string dt = dpFrom.DisplayDate.ToString("dd-MM-yyyy");
                cmdSelect.Parameters.AddWithValue("@from", dpFrom.DisplayDate.ToString("dd/MM/yyyy"));
                cmdSelect.Parameters.AddWithValue("@to", dpTo.DisplayDate.ToString("dd/MM/yyyy"));

                SqlDataReader reader = await cmdSelect.ExecuteReaderAsync();
                List<ClientsOrdersSumm> clientsSumm = new List<ClientsOrdersSumm>();
                while (await reader.ReadAsync())
                {
                    Customer cust = new Customer()
                    {
                        ContactName = reader[0].ToString(),
                        CompanyName = reader[1].ToString(),
                        City = reader[2].ToString(),
                        Country = reader[3].ToString()
                    };
                    ClientsOrdersSumm cos = new ClientsOrdersSumm() 
                    {
                        customer = cust,
                        Summ = Convert.ToDecimal(String.Format("{0:0.##}", reader[4]))
                    };
                    clientsSumm.Add(cos);
                }
                dgClientsOrdersSumm.ItemsSource = clientsSumm;
            }
            catch (Exception ex)
            {
                throw ex;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                pbProgress.IsIndeterminate = false;
            }
        }

    }
}
