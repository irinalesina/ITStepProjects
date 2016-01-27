using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization
{
    public static class DBConnector
    {
        static SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\v11.0;AttachDbFilename=D:\ITStepProjects\ADO.NET\2_Authorization_ADO\Authorization\Autorization.mdf;Integrated Security=True");
        
        public static bool FindLogin(string login)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Count(*) FROM Users WHERE NAME=@NAME", connection);
                command.Parameters.AddWithValue("@NAME", login);
                int res = (int)command.ExecuteScalar();
                return res == 0 ? false : true;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }


        public static bool CheckUser(string login, string password)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Count(*) FROM Users WHERE NAME=@NAME AND PASSWORD=@PASSWORD", connection);
                command.Parameters.AddWithValue("@NAME", login);
                command.Parameters.AddWithValue("@PASSWORD", password);
                int res = (int)command.ExecuteScalar();
                return res == 0 ? false : true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }


        //public static bool AddUser(string login, string password)
        //{
        //    try
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand("SELECT Count(*) FROM Users WHERE NAME=@NAME AND PASSWORD=@PASSWORD", connection);
        //        command.Parameters.AddWithValue("@NAME", login);
        //        command.Parameters.AddWithValue("@PASSWORD", password);
        //        return (bool)command.ExecuteScalar();
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}

    }
}
