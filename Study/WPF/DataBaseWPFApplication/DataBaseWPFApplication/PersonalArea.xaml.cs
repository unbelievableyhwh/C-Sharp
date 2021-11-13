using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DataBaseWPFApplication
{
    /// <summary>
    /// Логика взаимодействия для PersonalArea.xaml
    /// </summary>
    public partial class PersonalArea : Window
    {
        string constr = "server=127.0.0.1; database=''; user=root; password=''; port=3306; charset=utf8; ";
        string tableZap = "SHOW DATABASES;";
        MySqlConnection conn = null;
        MySqlDataAdapter adap = null;
        DataTable table = null;
        public PersonalArea()
        {
            InitializeComponent();
            MySqlConnection conn = new MySqlConnection(constr);

            try
            {
                conn.Open();
                adap = new MySqlDataAdapter(tableZap, conn);
                table = new DataTable();
                adap.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    tableNav.Items.Insert(i, table.Rows[i][0]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public PersonalArea(string login)
        {
            InitializeComponent();
            MySqlConnection conn = new MySqlConnection(constr);
            
            try
            {
                conn.Open();
                adap = new MySqlDataAdapter(tableZap, conn);
                table = new DataTable();
                adap.Fill(table);
                for(int i = 0; i<table.Rows.Count; i++)
                {
                    tableNav.Items.Insert(i, table.Rows[i][0]);
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tableNav_Selected(object sender, RoutedEventArgs e)
        {
            string strsql = $"SELECT * FROM {tableNav.Items[tableNav.SelectedIndex]};";
            conn = new MySqlConnection(constr);
            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(strsql, conn);
                DataTable table1 = new DataTable();
                adapter.Fill(table1);
                dataGrid.ItemsSource = table1.DefaultView;
                dataGrid.AutoGenerateColumns = true;
                dataGrid.CanUserAddRows = false;
                conn.Close();
            }
            catch(Exception ex1)
            {
                MessageBox.Show(ex1.ToString());
            }
        }
    }
}
