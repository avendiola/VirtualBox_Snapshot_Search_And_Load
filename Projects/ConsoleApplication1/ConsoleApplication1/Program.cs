using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                //sets a wellformed connection string (domain;database name;user;EmtyPasswordInmyCase)
                string connectionString = "Server=192.168.6.152; Database=cerberus; Uid=root; Pwd=123456";

                //creates the mysqlconnection Object
                MySqlConnection connection = new
                MySqlConnection(connectionString);

                //creates the mysqlcommand query
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM tickets";

                //creates the DataAdapter "dataAdapter"
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataSet dataSet = new dataSet();

                //fill the mysqldataadapter object "dataAdapter"
                //with data from tickets
                dataAdapter.Fill(dataSet, "Tickets");

                //creates the DataTable object from the previous loaded DataAdapter object to manipulate the data from the Ticket's table.
                DataTable builtTable = dataSet.Tables("Tickets");

                //prints the column titles
                foreach (DataColumn dc in builtTable.Columns)
                Console.Write(dc+"" | ");

                //a new line
                Console.WriteLine("");

                //loop the ticket table
                foreach (DataRow row in builtTable.Rows)
                {
                    foreach (var field in row.ItemArray)
                    {
                        Console.Write(field + " |");
                    }
                    Console.WriteLine("");
                }






        }
    }
}
