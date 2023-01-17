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
    /// Логика взаимодействия для Задание6.xaml
    /// </summary>
    public partial class Задание6 : Window
    {
        public Задание6()
        {
            InitializeComponent();
        }

        private void fa_Click(object sender, RoutedEventArgs e)
        {
            int s = 1;
            int s1 = 1;
            try
            {
                int f = Convert.ToInt32(FA.Text);
                if (s == f | f == 0)
                    l.Text = "1";
                else
                {
                by:
                    {
                        s = s * (s1 + 1);
                        s1++;
                    }

                    if (s1 == f)
                        l.Text = Convert.ToString(s);
                    else
                        goto by;
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат данных!");
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
