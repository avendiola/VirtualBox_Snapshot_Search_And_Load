using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tickets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //sets a wellformed connection string (domain;database name;user;EmptyPasswordInmyCase)
                string connectionString = "Server=192.168.6.152; Database=cerberus; Uid=root; Pwd=123456;";

                //creates the MySqlConnection Object
                MySqlConnection connection = new
                MySqlConnection(connectionString);

                //creates the MySqlCommand query
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM ticket";

                //creates the dataAdapter "dataAdapter"
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                //fill the mysqldataAdapter object "dataAdapter" with data from ticket.
                dataAdapter.Fill(dataSet, "Ticket");

                //creates the DataTable object from the previous loaded DataAdapter object
                //to manipulate the data from the Ticket table.
                DataTable builtTable = dataSet.Tables["Ticket"];


            }
            catch (MySqlException me)
            {
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "Server=192.168.6.152;uid=root;" +
                "pwd=123456;database=cerberus;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
