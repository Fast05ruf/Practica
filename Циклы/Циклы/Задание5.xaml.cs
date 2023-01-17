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
    /// Логика взаимодействия для Задание5.xaml
    /// </summary>
    public partial class Задание5 : Window
    {
        public Задание5()
        {
            InitializeComponent();
        }

        private void MON_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(mon.Text);
                switch(x.SelectedIndex)
                {
                    case 0:
                        a = a*0.1;
                        break;
                    case 1:
                        a = a * 0.15;
                        break;
                    case 2:
                        a = a * 0.25;
                        break;
                    case 3:
                        a = a * 0.35;
                        break;
                    case 4:
                        a = a * 0.45;
                        break;
                    case 5:
                        a = a * 0.5;
                        break;
                }
                l.Text = Convert.ToString(a);
            }
            catch
            {
                l.Text = "Неверный формат данных";
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
