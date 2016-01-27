using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainControlSystem
{
    static class DBConnector
    {
        private static OleDbConnection connection;

        private static void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Resources/TrainControlSystemDB.accdb;Persist Security Info=False");
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

        /// <summary>
        ///  This method returns [train], [departureStation], [arrivalStation],
        ///  [arrivalTime], [departureTime].
        /// </summary>
        public static List<Dictionary<string, string>> SelectSchedule(string station)
        {
            List<Dictionary<string, string>> schedule = new List<Dictionary<string, string>>();
            try
            {
                OleDbCommand command = connection.CreateCommand();

                command.CommandText = "SELECT * FROM (SELECT " +
                    "[GotRoutes].[routeName] AS routeName, " +
                    "[DepartureStations].[stationName] AS departureStation, " +
                    "[ArrivalStations].[stationName] AS arrivalStation, " +
                    "[GotRoutes].[arrivalTime]/60/24 + [Schedule].[departureDateTime] AS arrivalDateTime, " +
                    "[GotRoutes].[departureTime]/60/24 + [Schedule].[departureDateTime] AS departureDateTime " +
                    "FROM (([Schedule] INNER JOIN " +
                           "(SELECT [Routes].[idRoute] AS idRoute, [Routes].[routeName] AS routeName, " +
                            "[Stations].[StationName] AS stationName, [Routes].[arrivalTime] AS arrivalTime, " +
                            "[Routes].[departureTime] AS departureTime FROM " +
                           "[Routes] INNER JOIN [Stations] ON [Routes].[idStation]=[Stations].[idStation] " +
                         "WHERE [Stations].[stationName] = ? ) GotRoutes ON [Schedule].[idRoute] = [GotRoutes].[idRoute]) " +
                      "INNER JOIN Stations AS [DepartureStations] ON [Schedule].[idStationFrom] = [DepartureStations].[idStation]) " +
                    "INNER JOIN [Stations] AS [ArrivalStations] ON [Schedule].[idStationTo] = [ArrivalStations].[idStation] " +
                    "WHERE ([GotRoutes].[departureTime]/60/24 + [Schedule].[departureDateTime]) BETWEEN ? AND ?) Unsorted " +
                    "ORDER BY [Unsorted].[arrivalDateTime]";

                command.CommandType = CommandType.Text;

                var p1 = command.CreateParameter();
                p1.Value = station;
                command.Parameters.Add(p1);

                var p2 = command.CreateParameter();
                p2.Value = DateTime.Now.ToString();
                command.Parameters.Add(p2);

                var p3 = command.CreateParameter();
                p3.Value = DateTime.Now.AddDays(2).ToString();
                command.Parameters.Add(p3);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Dictionary<string, string> scheduleStr = new Dictionary<string, string>();
                    scheduleStr.Add("train", reader["routeName"].ToString());
                    scheduleStr.Add("departureStation", reader["departureStation"].ToString());
                    scheduleStr.Add("arrivalStation", reader["arrivalStation"].ToString());
                    scheduleStr.Add("arrivalDateTime", Convert.ToDateTime(reader["arrivalDateTime"]).ToString());
                    scheduleStr.Add("departureDateTime", Convert.ToDateTime(reader["departureDateTime"]).ToString());

                    schedule.Add(scheduleStr);
                }
                reader.Close();
                return schedule;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// return station name
        /// </summary>
        public static List<string> SelectStations()
        {
            List<string> stations = new List<string>();
            try
            {
                OleDbCommand command = connection.CreateCommand();

                command.CommandText = "SELECT [stationName] FROM [Stations]";

                command.CommandType = CommandType.Text;


                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    stations.Add(reader["stationName"].ToString());
                }
                reader.Close();
                stations.Sort();
                return stations;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// key = stationName, value = idStation
        /// </summary>
        public static Dictionary<string, string> SelectStationsWithId()
        {
            Dictionary<string, string> stations = new Dictionary<string,string>();
            try
            {
                OleDbCommand command = connection.CreateCommand();

                command.CommandText = "SELECT * FROM [Stations]";

                command.CommandType = CommandType.Text;


                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    stations.Add(reader["stationName"].ToString(), reader["idStation"].ToString());
                }
                reader.Close();
                
                return stations;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// key = wagonType, value = idWagon
        /// </summary>
        public static SortedDictionary<string, string> SelectWagons()
        {
            SortedDictionary<string, string> wagons = new SortedDictionary<string, string>();
            try
            {
                OleDbCommand command = connection.CreateCommand();

                command.CommandText = "SELECT [Wagons].[idWagon] AS idWagon, [Wagons].[wagonType] AS wagonType FROM [Wagons]";

                command.CommandType = CommandType.Text;


                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    wagons.Add(reader["wagonType"].ToString(), reader["idWagon"].ToString());
                }
                reader.Close();

                return wagons;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<string> SelectTrains()
        {
            List<string> trains = new List<string>();
            try
            {
                OleDbCommand command = connection.CreateCommand();

                command.CommandText = "SELECT DISTINCT [idTrain] FROM [Trains]";

                command.CommandType = CommandType.Text;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    trains.Add(reader["idTrain"].ToString()); 
                }
                reader.Close();
                return trains;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///  This method returns key = [idRoute], value = [routeName]
        /// </summary>
        public static Dictionary<string, string> SelectRoutes()
        {
            Dictionary<string, string> routes = new Dictionary<string,string>();
            try
            {
                OleDbCommand command = connection.CreateCommand();

                command.CommandText = "SELECT [Routes].[idRoute] AS idRoute, Max([Routes].[routeName]) AS routeName FROM [Routes] GROUP BY [Routes].[idRoute]";

                command.CommandType = CommandType.Text;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    routes.Add(reader["idRoute"].ToString(), reader["routeName"].ToString());
                }
                reader.Close();
                return routes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string SelectIdStationFrom(string idRoute)
        {
            try
            {
                string idStationFrom = "";
                OleDbCommand command = connection.CreateCommand();

                command.CommandText = "SELECT [idStation] FROM [Routes] WHERE [Routes].[idRoute] = ? AND [Routes].[stationPosition] = 1";

                command.CommandType = CommandType.Text;

                var p1 = command.CreateParameter();
                p1.Value = idRoute;
                command.Parameters.Add(p1);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idStationFrom = reader["idStation"].ToString();
                }
                reader.Close();
                return idStationFrom;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string SelectIdStationTo(string idRoute)
        {
            try
            {
                string idStationTo = "";
                OleDbCommand command = connection.CreateCommand();

                command.CommandText = "SELECT TOP 1 [idStation] FROM [Routes] WHERE [Routes].[idRoute] = ? ORDER BY [Routes].[stationPosition] DESC";

                command.CommandType = CommandType.Text;

                var p1 = command.CreateParameter();
                p1.Value = idRoute;
                command.Parameters.Add(p1);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idStationTo = reader["idStation"].ToString();
                }
                reader.Close();
                return idStationTo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<string> SelectRouteStations(string idRoute)
        {
            List<string> stations = new List<string>();
            try
            {
                OleDbCommand command = connection.CreateCommand();

                command.CommandText = "SELECT [Stations].[stationName] AS stationName FROM [Routes] "+
                    "INNER JOIN [Stations] ON [Routes].[idStation] = [Stations].[idStation] "+
                    "WHERE [Routes].[idRoute] = ? ORDER BY [Routes].[stationPosition] ASC";

                command.CommandType = CommandType.Text;

                var p1 = command.CreateParameter();
                p1.Value = idRoute;
                command.Parameters.Add(p1);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    stations.Add(reader["stationName"].ToString());
                }
                reader.Close();
                return stations;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        ///  This method returns [train], [departureStation], [arrivalStation],
        ///  [arrivalTime], [departureTime].
        /// </summary>
        public static List<Dictionary<string, string>> SelectSchedule(string stationFrom, string stationTo, string departureDate)
        {
            List<Dictionary<string, string>> schedule = new List<Dictionary<string, string>>();

            try
            {
                OleDbCommand command = connection.CreateCommand();

                command.CommandText = "SELECT [FoundRoutes].[routeName] AS routeName, [StationsFrom].[stationName] AS departureStation, "+
                    "[StationsTo].[stationName] AS arrivalStation, [FoundRoutes].[arrivalTime]/60/24 + [Schedule].[departureDateTime] AS arrivalDateTime, "+
                    "[FoundRoutes].[departureTime]/60/24 + [Schedule].[DepartureDateTime] AS departureDateTime "+
                    "FROM (([Schedule] INNER JOIN (SELECT [RoutesFrom].[idRoute] AS idRoute, [RoutesFrom].[routeName] AS routeName, "+
                    "[RoutesFrom].[arrivalTime] AS arrivalTime, [RoutesFrom].[departureTime] AS departureTime "+
                    "FROM (SELECT * FROM Routes INNER JOIN Stations ON Routes.idStation=Stations.idStation WHERE Stations.stationName = ?) AS RoutesFrom "+
                    "INNER JOIN (SELECT * FROM Routes INNER JOIN Stations ON Routes.idStation=Stations.idStation WHERE Stations.stationName = ?) AS RoutesTo "+
                    "ON (RoutesFrom.idRoute=RoutesTo.idRoute) AND (RoutesFrom.stationPosition<RoutesTo.stationPosition))  AS FoundRoutes "+
                    "ON [Schedule].[idRoute] = [FoundRoutes].[idRoute]) INNER JOIN [Stations] AS StationsFrom ON [Schedule].[idStationFrom] = [StationsFrom].[idStation]) "+
                    "INNER JOIN [Stations] AS StationsTo ON [Schedule].[idStationTo] = [StationsTo].[idStation] "+
                    "WHERE DateValue([Schedule].[DepartureDateTime] + [FoundRoutes].[departureTime]/60/24) = ?";

                command.CommandType = CommandType.Text;

                var p1 = command.CreateParameter();
                p1.Value = stationFrom;
                command.Parameters.Add(p1);

                var p2 = command.CreateParameter();
                p2.Value = stationTo;
                command.Parameters.Add(p2);

                var p3 = command.CreateParameter();
                p3.Value = departureDate;
                command.Parameters.Add(p3);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Dictionary<string, string> scheduleStr = new Dictionary<string, string>();
                    scheduleStr.Add("train", reader["routeName"].ToString());
                    scheduleStr.Add("departureStation", reader["departureStation"].ToString());
                    scheduleStr.Add("arrivalStation", reader["arrivalStation"].ToString());
                    scheduleStr.Add("arrivalDateTime", Convert.ToDateTime(reader["arrivalDateTime"]).ToString());
                    scheduleStr.Add("departureDateTime", Convert.ToDateTime(reader["departureDateTime"]).ToString());

                    schedule.Add(scheduleStr);
                }
                reader.Close();
                return schedule;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void InsertRecordInSchedule(SortedDictionary<string, string> record)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();

                command.CommandText = "INSERT INTO Schedule ( idStationFrom, idStationTo, idRoute, idTrain, departureDateTime ) "+
                    "VALUES (?, ?, ?, ?, ?)";

                command.CommandType = CommandType.Text;

                var p1 = command.CreateParameter();
                p1.Value = SelectIdStationFrom(record["idRoute"]);
                command.Parameters.Add(p1);

                var p2 = command.CreateParameter();
                p2.Value = SelectIdStationTo(record["idRoute"]);
                command.Parameters.Add(p2);

                var p3 = command.CreateParameter();
                p3.Value = record["idRoute"];
                command.Parameters.Add(p3);

                var p4 = command.CreateParameter();
                p4.Value = record["idTrain"];
                command.Parameters.Add(p4);

                var p5 = command.CreateParameter();
                p5.Value = record["departureDateTime"];
                command.Parameters.Add(p5);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public static void InsertRoute(List<Dictionary<string, string>> route)
        {
            try
            {
                string idRoute = FindNextIdRoute();
                int stationPosition = route.Count;
                foreach (var routeString in route)
                {
                    OleDbCommand command = connection.CreateCommand();

                    command.CommandText = "INSERT INTO Routes ( idRoute, routeName, idStation, stationPosition, arrivalTime, departureTime ) " +
                        "VALUES (?, ?, ?, ?, ?, ?)";

                    command.CommandType = CommandType.Text;

                    var p1 = command.CreateParameter();
                    p1.Value = idRoute;
                    command.Parameters.Add(p1);

                    var p2 = command.CreateParameter();
                    p2.Value = routeString["routeName"];
                    command.Parameters.Add(p2);

                    var p3 = command.CreateParameter();
                    p3.Value = routeString["idStation"];
                    command.Parameters.Add(p3);

                    var p4 = command.CreateParameter();
                    p4.Value = (stationPosition--).ToString();
                    command.Parameters.Add(p4);

                    var arrivalTime = Convert.ToDateTime(routeString["arrivalTime"]);
                    var p5 = command.CreateParameter();
                    p5.Value = (arrivalTime.Hour * 60 + arrivalTime.Minute).ToString();
                    command.Parameters.Add(p5);

                    var departureTime = Convert.ToDateTime(routeString["departureTime"]);
                    var p6 = command.CreateParameter();
                    p6.Value = (departureTime.Hour * 60 + departureTime.Minute).ToString();
                    command.Parameters.Add(p6);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void InsertTrain(string CheckedTrainName, List<string> wagonsId)
        {
            try
            {
                string trainName = CheckedTrainName;
                int wagonPosition = 1;
                foreach (var wagon in wagonsId)
                {
                    OleDbCommand command = connection.CreateCommand();

                    command.CommandText = "INSERT INTO Trains ( idTrain, wagon, wagonNumber) " +
                        "VALUES (?, ?, ?)";

                    command.CommandType = CommandType.Text;

                    var p1 = command.CreateParameter();
                    p1.Value = trainName;
                    command.Parameters.Add(p1);

                    var p2 = command.CreateParameter();
                    p2.Value = wagon;
                    command.Parameters.Add(p2);

                    var p3 = command.CreateParameter();
                    p3.Value = (wagonPosition++).ToString();
                    command.Parameters.Add(p3);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static string FindNextIdRoute()
        {
            string nextIdRoute = "";
            try
            {
                OleDbCommand command = connection.CreateCommand();

                command.CommandText = "SELECT Max([Routes].[idRoute]) AS idRoute FROM [Routes]";

                command.CommandType = CommandType.Text;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    nextIdRoute = (Convert.ToInt32(reader["idRoute"]) + 1).ToString();
                }
                reader.Close();
                return nextIdRoute;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool TrainIdIsFound(string idTrain)
        {
            try
            {
                OleDbCommand command = connection.CreateCommand();

                command.CommandText = "SELECT DISTINCT [Trains].[idTrain] AS idTrain FROM [Trains] WHERE [Trains].[idTrain] = ?";

                command.CommandType = CommandType.Text;

                var p1 = command.CreateParameter();
                p1.Value = idTrain;
                command.Parameters.Add(p1);

                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();
                    return true;
                }
                reader.Close();
                return false;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
       
    }
}
