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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Практика3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void na1_Click(object sender, RoutedEventArgs e)
        {
            Задание1 mainWindow = new Задание1();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void na4_Click(object sender, RoutedEventArgs e)
        {
            Задание4 mainWindow = new Задание4();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void na3_Click(object sender, RoutedEventArgs e)
        {
            Задание3 mainWindow = new Задание3();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void na2_Click(object sender, RoutedEventArgs e)
        {
            Задание2 mainWindow = new Задание2();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
