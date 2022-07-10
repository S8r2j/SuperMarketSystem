using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Marketing_app
{
    internal class connection
    {
        static string server = "localhost";
        static string username = "root";
        static string password = "";
        static string database = "supermarketdatabase";
        static string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "USERNAME=" + username + ";" + "PASSWORD=" + password + ";";
        public static MySqlConnection connect;

        public static MySqlConnection connect2server()
        {
            connect = new MySqlConnection(connectionString);
            connect.Open();
            return connect;
        }
    }
}
