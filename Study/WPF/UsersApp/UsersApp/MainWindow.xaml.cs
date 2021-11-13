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

namespace UsersApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = PassBox.Password.Trim();
            string pass2 = PassBox_2.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();

            if(login.Length < 5)
            {
                textBoxLogin.ToolTip = "This field is entered incorrectly!";
                textBoxLogin.Background = Brushes.Red;
            }else if(pass.Length < 5)
            {
                PassBox.ToolTip = "This field is entered incorrectly!";
                PassBox.Background = Brushes.Red;
            }
            else if (pass != pass2)
            {
                PassBox_2.ToolTip = "This field is entered incorrectly!";
                PassBox_2.Background = Brushes.Red;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textBoxEmail.ToolTip = "This field is entered incorrectly!";
                textBoxEmail.Background = Brushes.Red;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                PassBox.ToolTip = "";
                PassBox.Background = Brushes.Transparent;
                PassBox_2.ToolTip = "";
                PassBox_2.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                MessageBox.Show("Congratulations!!!");

                User user = new User(login, pass, email);

                db.Users.Add(user);
                db.SaveChanges();

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AuthWindow auth = new AuthWindow();
            auth.Show();
        }
    }
}
