using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_OLE_DB
{
    static class DBConnector
    {
        private static OleDbConnection connection;

        private static void ConnectTo()
        {
            connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=../../med.mdb");
            
        }

        static DBConnector()
        {
            ConnectTo();

        }


        public static void PatientsInfo()
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT * FROM Patients", connection);

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                 {
                  Console.WriteLine("{0}\n{1}\n{2}\n{3}\n",
                                    reader[0], reader[1], reader[2], reader[3]);
                 }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void DoctorsCount()
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT Count(*) FROM Doctors", connection);

                int linesCount = (int)command.ExecuteScalar();
                Console.WriteLine(linesCount);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void PatientDoctor()
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT DISTINCT Doctors.doctorName, Patients.patientName "+
                    "FROM Patients INNER JOIN (Doctors INNER JOIN Visits ON Doctors.doctorID = Visits.visitDoctor) ON Patients.patientID = Visits.visitPatient;", connection);

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0} - {1}",
                                      reader[0], reader[1]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void DoctorPrice()
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT Doctors.doctorName, VisitCosts.visitCostValue "+
                    "FROM Doctors, VisitCosts;", connection);

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0} - {1}",
                                      reader[0], reader[1]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Visits()
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT Doctors.doctorName, Format(Visits.visitDate, 'Long Date'), Format(Visits.visitTime, 'Medium Time'), Patients.patientName " +
                    "FROM Patients INNER JOIN (Doctors INNER JOIN Visits ON Doctors.doctorID = Visits.visitDoctor) ON Patients.patientID = Visits.visitPatient;", connection);

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0} - {1} {2} - {3}",
                                      reader[0], reader[1], reader[2], reader[3]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
