using System;
using System.Data;
using System.Data.Common; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace MySQLDBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder connBuilder =
                new MySqlConnectionStringBuilder();

            connBuilder.Add("Database", "my_cerberus");
            connBuilder.Add("Data Source", "localhost");
            connBuilder.Add("User ID", "root");
            connBuilder.Add("Password", "123456");

            MySqlConnection connection;
            new MySqlConnection(connBuilder.ConnectionString);

            MySqlCommand cmd = connection.CreateCommand();

            connection.Open();

            //here goes the code needed to perform operations on the

            //database such as querying or inserting rows into a table

            connection.Close();

        }
    }
}

