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
    /// Логика взаимодействия для Задание_6.xaml
    /// </summary>
    public partial class Задание_6 : Window
    {
        public Задание_6()
        {
            InitializeComponent();
        }
        List <string> room = new List<string>();
        int gg = 0;
        private void Dob_Click(object sender, RoutedEventArgs e)
        {
            l1.Content = "";
            try
            {
                gg += 1;
                if (gg == 1)
                {
                    string a = Convert.ToString(F.Text);
                    room.Add("Ваше имя:" + a);
                    l.Text = "Сколько вам лет?";
                }
                else if (gg == 2)
                {
                    int a = Convert.ToInt32(F.Text);
                    if (a <= 0)
                    {
                        l1.Content = "Неверный формат данных";
                        l1.Foreground = Brushes.Red;
                    }
                    else
                    {
                        room.Add("Ваш возраст:" + a);
                        l.Text = "Какой ваш знак зодиака?";
                    }
                }
                else if (gg == 3)
                {
                    string a = Convert.ToString(F.Text);
                    room.Add("Ваш знак зодиака:" + a);
                    l.Text = "Кем вы работаете?";
                }
                else if (gg == 4)
                {
                    string a = Convert.ToString(F.Text);
                    room.Add("Ваша деятельность:" + a);
                    l.Text = "";
                    for (int i = 0; i < room.Count; i++)
                        l.Text += room[i] + "\n";
                    Dob.Content = "Очистить данные";
                }
                else if (gg == 5)
                {
                    l.Text = "Как вас зовут?";
                    gg = 0;
                    room.Clear();
                    Dob.Content = "Добавить данные";
                }
            }
            catch
            {
                gg = 1;
                l1.Content = "Неверный формат данных";
                l1.Foreground = Brushes.Red;
            }
            F.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

    }
}
