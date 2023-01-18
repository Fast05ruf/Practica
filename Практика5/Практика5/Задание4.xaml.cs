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

        int i = 0;
        private void pay_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int y = Convert.ToInt32(payment.Text);
                int x = 0;
                x += y;
                if (i <= 7)
                {
                    if (x < 5000)
                    {
                        Info.Text = $"Сумма задолженности {5000 - x}";
                        i++;
                    }
                    else if (x == 5000)
                    {
                        i++;
                        Info.Text = "Долг погашен";
                    }
                    else if (x > 5000)
                    {
                        i++;
                        Info.Text = $"Долг погашен, переплата {x - 5000}";
                    }
                }
                else
                    Info.Text = "Вы не успели погасить долг";
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
