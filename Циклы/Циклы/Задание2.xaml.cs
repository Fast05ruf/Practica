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

namespace Циклы
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
        private void fa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int f = Convert.ToInt32(l.Text);
                int y = 1;
                int x = 1;
                if (f < 0)
                    MessageBox.Show("Введите положительное число");

                if (f == 1 | f == 0)
                    res.Text = "1";
                else
                {
                    do
                    {
                        x = Math.Abs(x * (y + 1));
                        y++;
                    }
                    while (y != f);
                    res.Text = Convert.ToString(x);
                }
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
