using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataBaseEditor
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
        }

        //Регистрация
        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            string login, pass, pass2;
            login = textBoxLogin.Text.Trim();
            pass = passBox.Password.Trim();
            pass2 = passBox2.Password.Trim();

            if (login.Length < 4 || login.Length == 0)
            {
                textBoxLogin.ToolTip = "This field is entered incorrectly!";
                textBoxLogin.BorderBrush = Brushes.Red;
                textBoxLogin.Foreground = Brushes.Red;
            }
            else if (pass.Length < 4 || pass.Length == 0)
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
                DBEditor db = new DBEditor();
                if (db.Registration(login, pass))
                {
                    MessageBox.Show("You have successfully registred!");
                    AuthWindow auth = new AuthWindow();
                    auth.Show();
                    this.Hide();
                }
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow auth = new AuthWindow();
            auth.Show();
            Hide();
        }
    }
}
