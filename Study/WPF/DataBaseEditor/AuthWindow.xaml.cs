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
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }
        //Авторизация
        private void signInButton_Click(object sender, RoutedEventArgs e)
        {
            string login, pass;
            login = textBoxLogin.Text.Trim();
            pass = passBox.Password.Trim();

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
            else
            {
                DBEditor db = new DBEditor();
                if (db.Authorization(login, pass))
                {
                    MainWindow main = new MainWindow();
                    main.labelLogin.Text = $"Welcome back, {login}!";
                    main.Show();
                    Hide();
                }
            }
        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            RegWindow reg = new RegWindow();
            reg.Show();
            Hide();
        }
    }
}
