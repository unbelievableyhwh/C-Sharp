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

namespace UsersApp
{
    /// <summary>
    /// Логика взаимодействия для ListOfUsers.xaml
    /// </summary>
    public partial class ListOfUsers : Window
    {
        public ListOfUsers()
        {
            InitializeComponent();
            ApplicationContext db = new ApplicationContext();
            List<User> users = db.Users.ToList();
            listOfUsers.ItemsSource = users;
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow auth = new AuthWindow();
            auth.Show();
            this.Hide();
        }
    }
}
