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
    /// Логика взаимодействия для Задание4.xaml
    /// </summary>
    public partial class Задание4 : Window
    {
        public Задание4()
        {
            InitializeComponent();
        }
        int c = 0;
        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            c = 0;
            int n = Convert.ToInt32(l.Text);
            for(int i = 0; i < n+1; i++)
            {
                c += i;
            }
            res.Text = "Сумма: "+Convert.ToString(c);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
