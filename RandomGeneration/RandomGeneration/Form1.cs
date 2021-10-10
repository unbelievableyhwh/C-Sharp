using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGeneration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void rndgen()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 100);
            label1.Text = a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rndgen();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
        }
    }
}
