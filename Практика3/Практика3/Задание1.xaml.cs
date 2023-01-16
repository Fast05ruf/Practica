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

namespace Практика3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            l.Content = "";
            try
            {
                string a = Convert.ToString(tran.Text);
                if (a == "дождь")
                    res.Text = "rain";
                else if (a == "ветер")
                    res.Text = "wind";
                else if (a == "снег")
                    res.Text = "snow";
                else if (a == "тепло")
                    res.Text = "warm";
                else if (a == "ходод")
                    res.Text = "cold";
                else if (a == "радуга")
                    res.Text = "rainbow";
                else if (a == "ураган")
                    res.Text = "hurricane";
                else if (a == "солнечно")
                    res.Text = "sunny";
                else if (a == "пасмурно")
                    res.Text = "cloudy";
                else if (a == "прогноз")
                    res.Text = "forecast";
                else
                {
                    l.Content = "Невозможно перевести слово";
                    l.Foreground = Brushes.Red;
                    res.Text = "";
                }
            
            }
            catch
            {}
        }

        private void RES_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
