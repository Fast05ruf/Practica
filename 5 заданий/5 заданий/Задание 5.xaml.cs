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
    /// Логика взаимодействия для Задание_5.xaml
    /// </summary>
    public partial class Задание_5 : Window
    {
        public Задание_5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void Time_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int people = Convert.ToInt32(Zap.Text);
                int min = people * 10;
                double houre = (min / 60);
                double houre1 = Math.Truncate(houre);
                double min1 = min - houre1 * 60;
                End.Text = Convert.ToString(houre) + " часа " + min1 + " минут";
            }
            catch
            {
                End.Text = "Не верный формат данных";
                End.Foreground = Brushes.Red;
            }
        }
    }
}
