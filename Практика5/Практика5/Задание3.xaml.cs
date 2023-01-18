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

        public string Vr()
        {
            string c = "";
            double x = Convert.ToDouble(number1.Text);
            if (x >= 0)
                c = "Число положительное, ";
            else
                c = "Число отрицательное, ";

            if (x/x == 1 & x/1 == x & x - Math.Truncate(x) == 0)
            {
                c += "число простое, ";
            }
            else
            {
                c += "число не простое, ";
            }
            if (x % 2 == 0 & x % 3 == 0 & x % 5 == 0 & x % 6 == 0 & x % 9 == 0)
            {
                c += "Число делится на 2, 3, 5, 6, 9 без остатка";
            }
            else
                c += "Число делится на 2, 3, 5, 6, 9 с остатком";
            return c;
        }

        private void check_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                answer3.Text = Vr();
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
