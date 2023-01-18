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
    /// Логика взаимодействия для Задание3.xaml
    /// </summary>
    public partial class Задание3 : Window
    {
        public Задание3()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(number1.Text);
                if (x >= 0)
                    answer3.Text = "Число положительное, ";
                else
                    answer3.Text = "Число отрицательное, ";

                bool prost = true;
                for (int i = 2; i <= x / 2; i++)
                {
                    if (x % i == 0)
                    {
                        prost = false;
                        break;
                    }
                }
                if (prost)
                {
                    answer3.Text += "число простое, ";
                }
                else
                {
                    answer3.Text += "число не простое, ";
                }
                if (x % 2 == 0 & x % 3 == 0 & x % 5 == 0 & x % 6 == 0 & x % 9 == 0)
                {
                    answer3.Text += "Число делится на 2, 3, 5, 6, 9 без остатка";
                }
                else
                    answer3.Text += "Число делится на 2, 3, 5, 6, 9 с остатком";
            }
            catch
            {
                MessageBox.Show("Неверный формат данных");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
