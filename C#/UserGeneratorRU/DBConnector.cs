using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserGeneratorRU
{
    static class DBConnector
    {
        private static OleDbConnection connection;

        private static void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Resources/InternetShop.accdb;Persist Security Info=False");
            connection.Open();
        }

        static DBConnector()
        {
            ConnectTo();
        }

        public static void CloseConnection()
        {
            connection.Close();
        }



        public static void AddShoppers(int count)
        {
            try
            {
                for (int i = 0; i < count; i++)
                {
                    OleDbCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO Shopper (FirstName, LastName, Patronymic, Birthday, IsFemale, Mail, Phone ) " +
                        "VALUES (?, ?, ?, ?, ?, ?, ?)";

                    command.CommandType = CommandType.Text;

                    List<string> FIO;
                    int isFemale;
                    string birthday = Generator.GenerateBirthday(DateTime.Now.Year - 18);

                    if (Generator.random.Next(2) == 1)
                    {
                        isFemale = 1;
                        FIO = Generator.GenerateFemale();
                    }
                    else
                    {
                        isFemale = 0;
                        FIO = Generator.GenerateMale();
                    }

                    var firstName = command.CreateParameter();
                    firstName.Value = FIO[1];
                    command.Parameters.Add(firstName);

                    var lastName = command.CreateParameter();
                    lastName.Value = FIO[0];
                    command.Parameters.Add(lastName);

                    var patronymic = command.CreateParameter();
                    patronymic.Value = FIO[2];
                    command.Parameters.Add(patronymic);

                    var birthdayPar = command.CreateParameter();
                    birthdayPar.Value = birthday;
                    command.Parameters.Add(birthdayPar);

                    var sex = command.CreateParameter();
                    sex.Value = isFemale;
                    command.Parameters.Add(sex);

                    var mail = command.CreateParameter();
                    mail.Value = Generator.GenerateEmail(FIO[1], FIO[0], birthday.Substring(birthday.Length - 4));
                    command.Parameters.Add(mail);

                    var phone = command.CreateParameter();
                    phone.Value = Generator.GeneratePhoneNumber();
                    command.Parameters.Add(phone);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }

}
