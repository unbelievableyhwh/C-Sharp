using System;
using System.Collections.Generic;
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

namespace DataBaseWPFApplication
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            string login, pass, pass2;
            login = textBoxLogin.Text.Trim();
            pass = passBox.Password.Trim();
            pass2 = passBox2.Password.Trim();

            if (login.Length < 3)
            {
                textBoxLogin.ToolTip = "This field is entered incorrectly!";
                textBoxLogin.BorderBrush = Brushes.Red;
                textBoxLogin.Foreground = Brushes.Red;
            }
            else if (pass.Length < 3)
            {
                textBoxLogin.ToolTip = "This field is entered incorrectly!";
                textBoxLogin.BorderBrush = Brushes.Red;
                textBoxLogin.Foreground = Brushes.Red;
            }
            else if (pass != pass2)
            {
                textBoxLogin.ToolTip = "This field is entered incorrectly!";
                textBoxLogin.BorderBrush = Brushes.Red;
                textBoxLogin.Foreground = Brushes.Red;
                MessageBox.Show("Passwords Mismatch!!!");
            }
            else
            {
                DBUserApplication db = new DBUserApplication();
                if (db.Registration(login, pass))
                {
                    MessageBox.Show("You have successfully registred!");
                    MainWindow auth = new MainWindow();
                    auth.Show();
                    this.Hide();
                }
            }
        }
    }
}
