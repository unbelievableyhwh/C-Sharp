using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Windows.Controls;
using System.IO;

namespace DataBaseEditor
{
    class DBEditor
    {
        private string constr = "server=127.0.0.1; database=dbeditor; user=root; password=''; port=3306; charset=utf8";
        private string withOutBase = "server=127.0.0.1; database=''; user=root; password=''; port=3306; charset=utf8";

        //Регистрация
        public bool Registration(string login, string password)
        {
            MySqlConnection conn = new MySqlConnection(constr);
            string strCommand = $"INSERT INTO users(Login, Password) Values('{login}', '{password}')";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(strCommand, conn);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        //Авторизация
        public bool Authorization(string login, string password) 
        {
            MySqlConnection conn = new MySqlConnection(constr);
            string strCommand = $"SELECT Password FROM users WHERE Login = '{login}'";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(strCommand, conn);
                MySqlDataReader dataReader = command.ExecuteReader();
                string pass = "";
                while (dataReader.Read())
                {
                    pass = dataReader.GetValue(0).ToString().Trim();
                }
                if (pass == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        //Получить список БД в комбобокс
        public DataTable GetDataBase()
        {
            MySqlConnection conn = new MySqlConnection(withOutBase);
            MySqlDataAdapter adap;
            DataTable table = new DataTable();
            try
            {
                conn.Open();
                adap = new MySqlDataAdapter("SHOW DATABASES;", conn);
                adap.Fill(table);
                return table;
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
                return table;
            }
            finally
            {
                conn.Close();
            }
        }
        //Получить список таблиц в комбобокс
        public DataTable GetTables(string baseName)
        {
            string newconn = $"server=127.0.0.1; database={baseName}; user=root; password=''; port=3306; charset=utf8";
            MySqlConnection conn = new MySqlConnection(newconn);
            MySqlDataAdapter adap;
            DataTable table = new DataTable();
            try
            {
                conn.Open();
                adap = new MySqlDataAdapter("SHOW TABLES;", conn);
                adap.Fill(table);
                return table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
                return table;
            }
            finally
            {
                conn.Close();
            }
        }
        //Получить данные из выбранной таблицы
        public DataTable GetData(string tableName, string baseName)
        {
            string newconn = $"server=127.0.0.1; database={baseName}; user=root; password=''; port=3306; charset=utf8";
            string command = $"SELECT * FROM {tableName};";
            MySqlConnection conn = new MySqlConnection(newconn);
            MySqlDataAdapter adap;
            DataTable table = new DataTable();
            try
            {
                conn.Open();
                adap = new MySqlDataAdapter(command, conn);
                adap.Fill(table);
                return table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
                return table;
            }
            finally
            {
                conn.Close();
            }
        }

        //Сохранить изменения в талице
        public void UpdateTable(DataTable table, string baseName, string tableName)
        {
            string newconn = $"server=127.0.0.1; database={baseName}; user=root; password=''; port=3306; charset=utf8";
            string command = $"SELECT * FROM {tableName};";
            MySqlConnection conn = new MySqlConnection(newconn);
            MySqlDataAdapter adap = new MySqlDataAdapter(command, newconn);
            try
            {
                conn.Open();
                MySqlCommand scb = new MySqlCommandBuilder(adap).GetUpdateCommand();
                adap.Update(table);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        //Сформировать страницу отчета с помощью таблицы
        public void HTMLReport(string path, string baseName, string tableName)
        {
            string[] columnName;
            DataTable table;
            string HTML_cod;
            string newconn = $"server=127.0.0.1; database={baseName}; user=root; password=''; port=3306; charset=utf8";
            string tableQuaery = $"SELECT * FROM {tableName};";
            MySqlConnection conn = new MySqlConnection(newconn);
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand(tableQuaery, conn);
                MySqlDataReader reader = comm.ExecuteReader();
                table = new DataTable();
                table = reader.GetSchemaTable();
                columnName = new string[table.Rows.Count];
                if (table != null)
                {
                    int i = 0;
                    foreach (DataRow drow in table.Rows)
                    {

                        columnName[i] = Convert.ToString(drow["ColumnName"]);
                        i++;
                    }
                }
                HTML_cod = "<html><head><title>ОТЧЕТ</title><meta http-equiv=\"content - type\" content=\"text / html\"; charset =\" utf-8\"> </head>" +
                     $"<body> <center><h1>Отчет данных {tableName}</h1><table border=\"1\">";
                File.WriteAllText(path, HTML_cod);
                HTML_cod = "<tr>";
                for (int j = 0; j < columnName.Length; j++)

                    HTML_cod += "<th>" + columnName[j] + "</th>";
                File.AppendAllText(path, HTML_cod);
                while (reader.Read())
                {
                    HTML_cod = "<tr>";
                    for (int j = 0; j < columnName.Length; j++)

                        HTML_cod += "<td>" + reader.GetValue(j).ToString() + "</td>";
                    HTML_cod += "</tr>";
                    File.AppendAllText(path, HTML_cod);
                }
                HTML_cod = "</center></body></html>";
                File.AppendAllText(path, HTML_cod);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
