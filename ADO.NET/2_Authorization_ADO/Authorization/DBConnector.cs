using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace Authorization
{
    public static class DBConnector
    {
        static SqlConnection connection; 
        
        static DBConnector()
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultCon"].ConnectionString;                
        }

        // sql stored procedure
        public static bool FindLogin(string login)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(@"FindLogin", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter paramInput = new SqlParameter();
                paramInput.ParameterName = "@login";
                paramInput.SqlDbType = SqlDbType.NVarChar;
                paramInput.Value = login;
                command.Parameters.Add(paramInput);

                SqlParameter paramOutput = new SqlParameter();
                paramOutput.ParameterName = "@result";
                paramOutput.SqlDbType = SqlDbType.Int;
                paramOutput.Direction = ParameterDirection.Output;
                command.Parameters.Add(paramOutput);

                command.ExecuteNonQuery();
                return (int)command.Parameters["@result"].Value == 0 ? false : true;
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

        //sql transaction
        public static bool AddUser(string login, string password, string email, string firstName, string lastName)
        {
            SqlTransaction trans = null;

            try
            {
                connection.Open();

                trans = connection.BeginTransaction();
                
                SqlCommand insertUser = new SqlCommand("INSERT INTO Users VALUES(@login, @password, @email)", connection);
                insertUser.Parameters.AddWithValue("@login", login);
                insertUser.Parameters.AddWithValue("@password", password);
                insertUser.Parameters.AddWithValue("@email", email);
                insertUser.Transaction = trans;
                insertUser.ExecuteNonQuery();

                SqlCommand getAddedUserId = new SqlCommand("SELECT Id FROM Users WHERE Name=@login AND Password=@password", connection);
                getAddedUserId.Parameters.AddWithValue("@login", login);
                getAddedUserId.Parameters.AddWithValue("@password", password);
                getAddedUserId.Transaction = trans;
                SqlDataReader reader = insertUser.ExecuteReader();
                reader.Read();
                string id = reader["Id"].ToString();
                reader.Close();

                SqlCommand insertUserInfo = new SqlCommand("INSERT INTO UsersInfo (Id, FirstName, LastName) VALUES (@id, @fn, @ln)", connection);
                insertUserInfo.Parameters.AddWithValue("@id", id);

                if(firstName == "")
                    insertUserInfo.Parameters.AddWithValue("@fn", DBNull.Value);
                else
                    insertUserInfo.Parameters.AddWithValue("@fn", firstName);

                if(lastName == "")
                    insertUserInfo.Parameters.AddWithValue("@ln", DBNull.Value);
                else
                    insertUserInfo.Parameters.AddWithValue("@ln", lastName);
                insertUserInfo.Transaction = trans;
                insertUserInfo.ExecuteNonQuery();

                trans.Commit();

                return true;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool UpdatePassword(string newPassword, string email)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Users SET Password=@password WHERE Email=@email", connection);
                command.Parameters.AddWithValue("@password", newPassword);
                command.Parameters.AddWithValue("@email", email);
                int res = command.ExecuteNonQuery();
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

    }
}
