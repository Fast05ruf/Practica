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
    /// Логика взаимодействия для Задание1.xaml
    /// </summary>
    public partial class Задание1 : Window
    {
        public Задание1()
        {
            InitializeComponent();
        }
        private int value1 = 0;
        private int value2 = 0;
        private int c = 0;
        private string c1 = "";

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            c = 0;
            try
            {
                value1 = Convert.ToInt32(A.Text);
                value2 = Convert.ToInt32(B.Text);
                if (value1 >= value2)
                {
                    MessageBox.Show("У вас одинаковые числа или первое число больше второго!");
                }
                else
                {
                    for (int i = value1 + 1; i < value2; i++)
                    {
                        if (i % 2 == 0)
                            c += i;
                        else
                        { c1 += i + " "; c += i; }
                        
                        
                    }
                    MessageBox.Show("Сумма: "+ c.ToString() + " Нечётные числа: " + c1);
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
