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
    /// Логика взаимодействия для Задание3.xaml
    /// </summary>
    public partial class Задание3 : Window
    {
        public Задание3()
        {
            InitializeComponent();
        }
        int sq = 0;
        private void Sq_Click(object sender, RoutedEventArgs e)
        {
            for ( int i = 10; i<21; i++ )
            {
                sq = (i * i);
                l.Text += Convert.ToString(sq) + " ";
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
