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

namespace _5_заданий
{
    /// <summary>
    /// Логика взаимодействия для Задание_4.xaml
    /// </summary>
    public partial class Задание_4 : Window
    {
        public Задание_4()
        {
            InitializeComponent();
        }
        double gold = 0;
        int crystal = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void Gold_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                gold = Convert.ToDouble(Kolv.Text);
                Gold.Content = "Обновить количество золота";
                Z.Content = gold;
                Buy.IsEnabled = true;
                CR.IsEnabled = true;
            }
            catch
            {
                MessageBox.Show("Неверный формат данных");
            }
        }

        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int crystalbuy = Convert.ToInt32(CR.Text);
                gold -= crystalbuy * 20;
                crystal += crystalbuy;
                if (gold < 0)
                {
                    crystal -= crystalbuy;
                    gold += crystalbuy * 20;
                    MessageBox.Show("Не хватает золота");
                }
                else
                {
                    K.Content = crystal;
                    Z.Content = gold;
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат данных");
            }
        }
    }
}
