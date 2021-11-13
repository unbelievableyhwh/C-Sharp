using MySql.Data.MySqlClient;
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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void tbLogin_Enter_1(object sender, EventArgs e)
        {
            if (tbLogin.Text == "Please enter login...")
            {
                tbLogin.Text = "";
                tbLogin.ForeColor = Color.Black;
            }
        }

        private void btnAuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAuOk_Click(object sender, EventArgs e)
        {
            if(tbLogin.Text == "Please enter login..." || tbLogin.Text == "")
            {
                MessageBox.Show("Please enter a login");
                return;
            }else if (tbPass.Text == "")
            {
                MessageBox.Show("Please enter a password");
                return;
            }

            string login = tbLogin.Text;
            string pass = tbPass.Text;
            string passcheck;
            DataBaseObject db = new DataBaseObject();
            string query1 = "SELECT * FROM user WHERE UserName = '" + login + "';";
            string query2 = "SELECT Password FROM user WHERE UserName = '" + login + "';";
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();
            PersonalArea pa = new PersonalArea();

            try
            {
                db.openConnection();
                MySqlCommand command1 = new MySqlCommand(query2, db.connection);
                adapter = new MySqlDataAdapter(query1, db.connection);
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    passcheck = Convert.ToString(command1.ExecuteScalar());
                    if (pass == passcheck)
                    {
                        db.changeUserVariable(login);
                        this.Hide();
                        pa.Show();
                    }
                    else MessageBox.Show("Incorrect password!!!");
                }
                else MessageBox.Show("Such a user was not found!!!");
            }
            catch(Exception ex1)
            {
                MessageBox.Show(ex1.ToString());
            }
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registr = new Registration();
            registr.Show();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }
    }
}
