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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnCancelReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization auth = new Authorization();
            auth.Show();
        }

        private void btnCAReg_Click(object sender, EventArgs e)
        {
            string login = tbLoginReg.Text;
            string pass = tbPassReg.Text;
            string repass = tbPassRegRep.Text;
            DataBaseObject db = new DataBaseObject();
            string query1 = "INSERT INTO user(UserName, Password) VALUES('" + login + "', '" + pass + "')";
            if(login == "")
            {
                MessageBox.Show("Please enter a login!");
                return;
            }else if(pass == "")
            {
                MessageBox.Show("Please enter a password!");
                return;
            }else if (repass == "")
            {
                MessageBox.Show("Please repeat a password!");
                return;
            }else if (pass != repass)
            {
                MessageBox.Show("Password mismatch! Please check your password..");
                return;
            }
            try
            {
                db.openConnection();
                MySqlCommand command1 = new MySqlCommand(query1, db.connection);
                command1.ExecuteNonQuery();
                MessageBox.Show("Account successfully created!");
                db.closeConnection();
            }
            catch(Exception ex2)
            {
                MessageBox.Show(ex2.ToString());
            }

            this.Hide();
            Authorization auth = new Authorization();
            auth.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
