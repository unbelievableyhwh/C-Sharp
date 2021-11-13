using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CorporateDistributionBot
{
    class DataBaseObject
    {
        string strconnection = "server=127.0.0.1; database=corporate_distribution; user=root; password=''; port=3306; charset=utf8";
        public MySqlConnection connection;

        public void openConnection()
        {
            connection = new MySqlConnection(strconnection);
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
                else return;
            }
            catch(Exception ex4)
            {
                Console.WriteLine(ex4.ToString());
            }
        }
        public void closeConnection()
        {
            connection = new MySqlConnection(strconnection);
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public string[] getMessage()
        {
            string[] message = null;
            string query = "SELECT Text FROM message WHERE Status = 1";
            MySqlDataAdapter adapter1;
            DataTable table1;
            openConnection();
            adapter1 = new MySqlDataAdapter(query, connection);
            table1 = new DataTable();
            adapter1.Fill(table1);
            for (int i = 0; i < table1.Rows.Count; i++)
                message[i] = Convert.ToString(table1.Rows[i][0]);
            return message;

        }
    }
}
