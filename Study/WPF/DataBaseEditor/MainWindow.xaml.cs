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
using System.Data;
using System.Threading;
using System.IO;

namespace DataBaseEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DBEditor db = new DBEditor();
            ComboBoxFill(baseNav, db.GetDataBase()); //Заполнить список БД
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //Метод заполнения списков
        private void ComboBoxFill(ComboBox combo, DataTable table)
        {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    combo.Items.Insert(i, table.Rows[i][0]);
                }
        }

        //Получить и заполнить список таблиц
        private void baseNav_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string baseName = (string)baseNav.Items[baseNav.SelectedIndex];
            DBEditor db = new DBEditor();
            DataTable table = new DataTable();
            table = db.GetTables(baseName);
            tableNav.SelectedItem = null;
            tableNav.Items.Clear();
            ComboBoxFill(tableNav, table);
        }

        //Получить данные из таблицы
        public void tableNav_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string tableName = (string)tableNav.Items[tableNav.SelectedIndex];
                string baseName = (string)baseNav.Items[baseNav.SelectedIndex];
                DBEditor db = new DBEditor();
                DataTable table = new DataTable();
                table = db.GetData(tableName, baseName);
                dataGrid.ItemsSource = table.DefaultView;
            }
            catch //Заглушка
            {
            }
        }
        //Обновить dataGrid
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if(dataGrid.ItemsSource != null)
            {
                tableNav.RaiseEvent(new SelectionChangedEventArgs(
                ComboBox.SelectionChangedEvent,
                new List<ComboBoxItem> { tableNav.Items[0] as ComboBoxItem },
                new List<ComboBoxItem> { tableNav.SelectedItem as ComboBoxItem }));
            }
        }
        //Сохранить изменения 
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(dataGrid.ItemsSource != null)
            {
                string tableName = (string)tableNav.Items[tableNav.SelectedIndex];
                string baseName = (string)baseNav.Items[baseNav.SelectedIndex];
                DBEditor db = new DBEditor();
                DataTable table = new DataTable();
                table = ((DataView)dataGrid.ItemsSource).ToTable();
                db.UpdateTable(table, baseName, tableName);
            }
        }
        //Получить отчёт html и/или распечатать
        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.ItemsSource != null)
            {
                string tableName = (string)tableNav.Items[tableNav.SelectedIndex];
                string baseName = (string)baseNav.Items[baseNav.SelectedIndex];
                string path = Environment.CurrentDirectory + "report.html";
                DBEditor db = new DBEditor();
                db.HTMLReport(path, baseName, tableName);
                Browser webBrowser = new Browser();
                Uri ur = new Uri(path);
                webBrowser.webReport.Navigate(ur);
                webBrowser.Show();
            }
        }
        //Сохранить таблицу в txt-файле
        private void btnTxt_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.ItemsSource != null)
            {
                string tableName = (string)tableNav.Items[tableNav.SelectedIndex];
                string baseName = (string)baseNav.Items[baseNav.SelectedIndex];
                DBEditor db = new DBEditor();
                DataTable table = db.GetData(tableName, baseName);
                try
                {
                    FileStream fs = File.Create($@"Reports\{tableName} Report " + DateTime.Now.ToShortDateString() + ".txt");
                    StreamWriter sw = new StreamWriter(fs);

                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
                            sw.Write(row[column] + "\t");
                        }
                        sw.WriteLine();
                    }
                    sw.Close();
                    fs.Close();
                    MessageBox.Show("File saved successfully!");
                }
                catch
                {
                    MessageBox.Show("Error! Something wrong...");
                }
            }
        }
    }
}
