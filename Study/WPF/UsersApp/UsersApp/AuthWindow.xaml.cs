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
using System.Windows.Media.Animation;

namespace UsersApp
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();

            DoubleAnimation btnAmimation = new DoubleAnimation();
            /*
            btnAmimation.From = 0;
            btnAmimation.To = 450;
            btnAmimation.Duration = TimeSpan.FromSeconds(2);
            SignInButton.BeginAnimation(Button.WidthProperty, btnAmimation);
            */
        }
        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = PassBox.Password.Trim();

            if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "This field is entered incorrectly!";
                textBoxLogin.Background = Brushes.Red;
            }
            else if (pass.Length < 5)
            {
                PassBox.ToolTip = "This field is entered incorrectly!";
                PassBox.Background = Brushes.Red;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                PassBox.ToolTip = "";
                PassBox.Background = Brushes.Transparent;

                User authUser = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    authUser = db.Users.Where(b => b.Login == login && b.Password == pass).FirstOrDefault();
                }
                if (authUser != null)
                {
                    ListOfUsers list = new ListOfUsers();
                    list.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Fall!");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Users_Click(object sender, RoutedEventArgs e)
        {
            ListOfUsers list = new ListOfUsers();
            list.Show();
            this.Hide();
        }
    }
}
