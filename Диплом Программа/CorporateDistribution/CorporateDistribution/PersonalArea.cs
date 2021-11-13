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
    public partial class PersonalArea : Form
    {
        string[] greetingWords = new string[]
        {
            "Welcome, @uN!",
            "Welcome back, @uN!",
            "Good day, @uN!",
            "Glad to see you, @uN!"
        };
        readonly Random rnd = new Random();
        DataBaseObject db = new DataBaseObject();
        public string userName;

        public PersonalArea()
        {
            InitializeComponent();
            
        }

        private void PersonalArea_Load(object sender, EventArgs e)
        {
            
        }

        private void PersonalArea_Shown(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                int numberWord = rnd.Next(0, 4);
                userName = db.GetUserName();
                lbPhrase.Text = greetingWords[numberWord].Replace("@uN", userName);
            }
            catch(Exception ex4)
            {
                MessageBox.Show(ex4.ToString());
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization auth = new Authorization();
            auth.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            AddContact ac = new AddContact();
            this.Hide();
            ac.Show();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            NewMessage nm = new NewMessage();
            this.Hide();
            nm.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewHistory vh = new ViewHistory();
            vh.Show();
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost/wp/corporatedistributionbot/");
        }
    }
}
