using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows;

namespace DataBaseWPFApplication
{
    class DBUserApplication
    {
        private string constr = "server=127.0.0.1; database=usersapplication; user=root; password=''; port=3306; charset=utf8";
        MySqlConnection conn = null;
        MySqlDataAdapter adap = null;
        DataTable tabl = null;
        MySqlCommandBuilder combil = null;
        MySqlDataReader dataRead = null;
        public DBUserApplication()
        {
        }
        public bool Registration(string login, string password)
        {
            conn = new MySqlConnection(constr);
            string strCommand = $"INSERT INTO users(Login, Password) VALUES('{login}','{password}');";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(strCommand, conn);
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public bool Authorization(string login, string password)
        {
            conn = new MySqlConnection(constr);
            string strCommand = $"SELECT Password FROM users WHERE Login = '{login}';";
            string pass = "";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(strCommand, conn);
                dataRead = command.ExecuteReader();
                while (dataRead.Read())
                {
                    pass = dataRead.GetValue(0).ToString().Trim();
                }
                if (pass != password)
                {
                    MessageBox.Show("Passwords Mismatch!");
                    return false;
                }
                else
                    return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
