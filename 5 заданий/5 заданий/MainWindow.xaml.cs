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

namespace _5_заданий
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
        //задание 1
        int apple; //хранит целое число от -2147483648 до 2147483647
        string text; //хранит набор символов Unicode
        char simbol; //хранит одиночный символ в кодировке Unicode
        double money; //хранит число с плавающей точкой от ±5.0*10^-324 до ±1.7*10^308
        object note; //хранит значение любого типа
        bool life; //хранит значение true или false
        float size; //хранит число с плавающей точкой от -3.4*10^38 до 3.4*10^38
        byte plate; //хранит целое число от 0 до 255
        sbyte score; //хранит целое число от -128 до 127
        ulong planet; //хранит целое число от 0 до 18 446 744 073 709 551 615

        private void na3_Click(object sender, RoutedEventArgs e)
        {
            Задание_3 mainWindow = new Задание_3();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void na6_Click(object sender, RoutedEventArgs e)
        {
            Задание_6 mainWindow = new Задание_6();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void na5_Click(object sender, RoutedEventArgs e)
        {
            Задание_5 mainWindow = new Задание_5();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void na4_Click(object sender, RoutedEventArgs e)
        {
            Задание_4 mainWindow = new Задание_4();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
