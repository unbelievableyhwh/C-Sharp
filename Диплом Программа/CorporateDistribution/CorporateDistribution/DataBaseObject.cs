using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorporateDistribution
{
    public class DataBaseObject
    {
        string strconnection = "server=127.0.0.1; database=corporatedistribution; user=root; password=''; port=3306; charset=utf8";
        public MySqlConnection connection;

        public void openConnection()
        {
            connection = new MySqlConnection(strconnection);
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
            else return;
        }
        public void closeConnection()
        {
            connection = new MySqlConnection(strconnection);
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public void changeUserVariable(string login)
        {
            string query1 = "SELECT idUser FROM user WHERE UserName = '" + login + "';";
            MySqlCommand command1 = new MySqlCommand(query1, connection);
            int variable = Convert.ToInt32(command1.ExecuteScalar());
            string query2 = "UPDATE variable SET id = '" + variable + "';" ;
            MySqlCommand command2 = new MySqlCommand(query2, connection);
            command2.ExecuteNonQuery();
        }
        public string GetUserName()
        {
            string userName;
            string query1 = "SELECT id FROM variable;";
            MySqlCommand command1 = new MySqlCommand(query1, connection);
            int idUser = Convert.ToInt32(command1.ExecuteScalar());
            string query2 = "SELECT UserName FROM user WHERE idUser = '" + idUser + "';";
            MySqlCommand command2 = new MySqlCommand(query2, connection);
            userName = Convert.ToString(command2.ExecuteScalar());
            return userName;
        }
    }
}
