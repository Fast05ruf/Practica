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
    /// Логика взаимодействия для Задание_3.xaml
    /// </summary>
    public partial class Задание_3 : Window
    {
        public Задание_3()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int a = random.Next(1, 18);
            int b = 52 - a*3;
            DDD.Text = "Количество полностью заполненных рядов картинками: " + a + ", количество картинок сверх меры: " + b;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
