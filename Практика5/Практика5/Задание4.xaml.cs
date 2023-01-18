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
    /// Логика взаимодействия для Задание4.xaml
    /// </summary>
    public partial class Задание4 : Window
    {
        public Задание4()
        {
            InitializeComponent();
        }

        double x = 0;
        int i = 0;
        public string Vr()
        {
            string c = "";
            double y = Convert.ToDouble(payment.Text);
            x += y;
            if (i < 7)
            {
                if (x < 5000)
                {
                    c = $"Сумма задолженности {5000 - x}";
                    i++;
                }
                else if (x == 5000)
                {
                    i++;
                    c = "Долг погашен";
                }
                else if (x > 5000)
                {
                    i++;
                    c = $"Долг погашен, переплата {x - 5000}";
                }
            }
            else
                c = "Вы не успели погасить долг";
            return c;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void pay_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Info.Text = Vr();
            }
            catch
            {
                MessageBox.Show("Неверный формаи данных");
            }
        }
    }
}
