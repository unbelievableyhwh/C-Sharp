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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBaseWPFApplication
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        private void signInButton_Click(object sender, RoutedEventArgs e)
        {
            string login, pass;
            login = textBoxLogin.Text.Trim();
            pass = passBox.Password.Trim();

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
            else
            {
                DBUserApplication db = new DBUserApplication();
                if (db.Authorization(login, pass))
                {
                    PersonalArea pa = new PersonalArea(login);
                    pa.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Something Wrong!");
            }
        }
    }
}
