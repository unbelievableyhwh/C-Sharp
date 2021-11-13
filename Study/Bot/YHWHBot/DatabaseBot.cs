using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace YHWHBot
{
    class DatabaseBot
    {
        private string connection = "server=127.0.0.1; database=yhwhbot; user=root; password=''; port=3306; charset=utf8";
        MySqlConnection conn = null;
        MySqlDataReader read = null;

        public bool Registration(string chatID, string username)
        {
            conn = new MySqlConnection(connection);
            try
            {
                conn.Open();
                if (Validation(chatID, username))
                {
                    return false;
                }
                else
                {
                    string command = $"INSERT INTO user(ChatID, UserName) VALUES('{chatID}', '{username}')";
                    MySqlCommand comm = new MySqlCommand(command, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                conn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
                return false;
            }
        }
        public bool Validation(string chatID, string username)
        {
            conn = new MySqlConnection(connection);
            try
            {
                conn.Open();
                string strComRead = $"SELECT UserName FROM user WHERE ChatID = '{chatID}'";
                string usernameChat = "";
                MySqlCommand commForRead = new MySqlCommand(strComRead, conn);
                read = commForRead.ExecuteReader();
                while (read.Read())
                    usernameChat = read.GetValue(0).ToString().Trim();
                if (usernameChat == username)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
                return false;
            }
        }
    }
}
