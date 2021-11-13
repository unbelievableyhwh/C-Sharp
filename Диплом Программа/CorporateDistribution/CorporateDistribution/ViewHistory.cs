using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorporateDistribution
{
    public partial class ViewHistory : Form
    {
        public string strconn = "server=127.0.0.1; database=ci; user=root; password=''; port=3306; charset=utf8";
        MySqlConnection conn1;
        MySqlDataAdapter adapter1 = null;
        DataTable table1 = new DataTable();
        string query1 = "SELECT * FROM message;";
        public ViewHistory()
        {
            InitializeComponent();
        }

        private void ViewHistory_Shown(object sender, EventArgs e)
        {
            try
            {
                conn1 = new MySqlConnection(strconn);
                conn1.Open();
                adapter1 = new MySqlDataAdapter(query1, conn1);
                table1 = new DataTable();
                adapter1.Fill(table1);
                
                bindingSource1.DataSource = table1;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                conn1.Close();
            }
            catch(Exception ex7)
            {
                MessageBox.Show(ex7.ToString());
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalArea pa = new PersonalArea();
            pa.Show();
        }

        private void ViewHistory_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }
    }
}
