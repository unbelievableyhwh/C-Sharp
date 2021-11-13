using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorporateDistribution
{
    public partial class NewMessage : Form
    {
        DataBaseObject db = new DataBaseObject();
        public NewMessage()
        {
            InitializeComponent();
        }

        private void NewMessage_Shown(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                string userName = db.GetUserName();
                string query1 = "SELECT idUser FROM user WHERE UserName = '" + userName + "';";
                MySqlCommand command1 = new MySqlCommand(query1, db.connection);
                int idUser = Convert.ToInt32(command1.ExecuteScalar());
                string query2 = "SELECT Name FROM contact WHERE User = '" + idUser + "';";
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(query2, db.connection);
                DataTable table = new DataTable();
                adapter1.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                    contactNav.Items.Insert(i, table.Rows[i][0]);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void contactNav_Enter(object sender, EventArgs e)
        {
            if (contactNav.Text == "Choose or enter contact...")
            {
                contactNav.Text = "";
                contactNav.ForeColor = Color.Black;
            }
        }

        private void btnNMBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalArea pa = new PersonalArea();
            pa.Show();
        }

        private void tbMessage_Enter(object sender, EventArgs e)
        {
            if (tbMessage.Text == "Enter your message...")
            {
                tbMessage.Text = "";
                tbMessage.ForeColor = Color.Black;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(tbMessage.Text != "Enter your message...")
            {
                tbMessage.Text = "";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(tbMessage.Text == "" || tbMessage.Text == "Enter your message...")
            {
                MessageBox.Show("Please enter message!");
                return;
            }
            else if(contactNav.Text == "" || contactNav.Text == "Choose or enter contact...")
            {
                MessageBox.Show("Incorrect contact! Please choose or enter contact...");
                return;
            }
            string message = tbMessage.Text;
            string contact = contactNav.Text;
            DateTime dataSent = new DateTime();
            try
            {
                string query1 = "INSERT INTO message(Text, Status) Values('" + message + "', '1');";
                MySqlCommand command1 = new MySqlCommand(query1, db.connection);
                command1.ExecuteNonQuery();
                string query2 = "SELECT idMessage FROM message WHERE Text = '" + message + "';";
                string query3 = "SELECT idContact FROM contact WHERE Name = '" + contact + "';";
                MySqlCommand command2 = new MySqlCommand(query2, db.connection);
                MySqlCommand command3 = new MySqlCommand(query3, db.connection);
                int idMess = Convert.ToInt32(command2.ExecuteScalar());
                int idCont = Convert.ToInt32(command3.ExecuteScalar());
                dataSent = DateTime.Now;
                string query4 = "INSERT INTO contact_message(Contact, Message, Time) Values('" + idCont +
                    "', '" + idMess + "', '" + dataSent + "');";
                MySqlCommand command4 = new MySqlCommand(query4, db.connection);
                command4.ExecuteNonQuery();
                MessageBox.Show("Message successfully sent!");
                tbMessage.Text = "";
                contactNav.Text = "";
            }
            catch(Exception ex5)
            {
                MessageBox.Show(ex5.ToString());
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbMessage.Text == "" || tbMessage.Text == "Enter your message...")
            {
                MessageBox.Show("Please enter message!");
                return;
            }
            else if (contactNav.Text == "" || contactNav.Text == "Choose or enter contact...")
            {
                MessageBox.Show("Incorrect contact! Please choose or enter contact...");
                return;
            }
            string message = tbMessage.Text;
            string contact = contactNav.Text;
            DateTime dataSent = new DateTime();
            string userName = db.GetUserName();
            dataSent = DateTime.Now;
            FileStream fs = new FileStream("Message_Copy_" + userName + "_" + dataSent.ToShortDateString() + ".txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                sw.WriteLine("Contact: '" + contact + "';");
                sw.WriteLine("Message: '" + message + "';");
                sw.WriteLine("Data: '" + dataSent + "';");
                MessageBox.Show("Message successfully saved!");
                sw.Close();
                fs.Close();
            }
            catch(Exception ex6)
            {
                MessageBox.Show(ex6.ToString());
            }
        }

        private void NewMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
