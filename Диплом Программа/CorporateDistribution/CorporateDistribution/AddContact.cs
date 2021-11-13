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
    public partial class AddContact : Form
    {
        PersonalArea pa = new PersonalArea();
        public AddContact()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            pa.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string contactName = tbAddContact.Text;
            if(contactName.Length == 0)
            {
                lbInfo.ForeColor = Color.Red;
                MessageBox.Show("Please enter the contact name!");
                return;
            }
            else if(contactName.Length > 32)
            {
                lbInfo.ForeColor = Color.Black;
                lbInfo2.ForeColor = Color.Red;
                MessageBox.Show("Сontact name is too long!");
                tbAddContact.Text = "";
                return;
            }
            lbInfo2.ForeColor = Color.Black;
            DataBaseObject db = new DataBaseObject();
            try
            {
                db.openConnection();
                string userName = db.GetUserName();
                string query1 = "SELECT * FROM variable;";
                MySqlCommand command1 = new MySqlCommand(query1, db.connection);
                int numberId = Convert.ToInt32(command1.ExecuteScalar());
                string query2 = "INSERT INTO contact(Name, User) VALUES('" + contactName + "', '" + numberId + "');";
                MySqlCommand command2 = new MySqlCommand(query2, db.connection);
                command2.ExecuteNonQuery();
                tbAddContact.Text = "";
                MessageBox.Show("Contact successfully added!");
            }
            catch (Exception ex5)
            {
                MessageBox.Show(ex5.ToString());
            }
        }
    }
}
