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

namespace Практика5
{
    /// <summary>
    /// Логика взаимодействия для Задание5.xaml
    /// </summary>
    public partial class Задание5 : Window
    {
        public Задание5()
        {
            InitializeComponent();
        }

        private void customersCount_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                int n = Convert.ToInt32(customers.Text);
                int i = 1;
                int sum = 1;
            LB1: if (i <= n)
                {
                    sum *= i;
                    i++;
                    goto LB1;
                }
                else
                    answer4.Text = Convert.ToString(sum);
            }
            catch { MessageBox.Show("Неверный формат данных"); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
