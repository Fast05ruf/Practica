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
    /// Логика взаимодействия для Задание2.xaml
    /// </summary>
    public partial class Задание2 : Window
    {
        public Задание2()
        {
            InitializeComponent();
        }

        public string Vr()
        {
            string c = "";
            double Money = Convert.ToDouble(money.Text);
            double Conversion = Convert.ToDouble(conversion.Text);
            c = Convert.ToString(Money * Conversion);
            return c;
        }

        private void countMoney_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                answer2.Content = Vr();
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
