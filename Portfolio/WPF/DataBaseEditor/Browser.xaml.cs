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
    /// Логика взаимодействия для Browser.xaml
    /// </summary>
    public partial class Browser : Window
    {
        public Browser()
        {
            InitializeComponent();
        }

        //Распечатать таблицу
        private void printButton_Click(object sender, RoutedEventArgs e)
        {
            //webReport.InvokeScript("execScript", new object[] { "window.print();", "JavaScript" });
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
            Close();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
