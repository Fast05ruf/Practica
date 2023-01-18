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

namespace Практика5
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
        public double Add()
        {
            double x = Convert.ToDouble(numberOne.Text);
            double y = Convert.ToDouble(numberTwo.Text);
            return x + y;
        }

        public double Sub()
        {
            double x = Convert.ToDouble(numberOne.Text);
            double y = Convert.ToDouble(numberTwo.Text);
            return x - y;
        }

        public double Mul()
        {
            double x = Convert.ToDouble(numberOne.Text);
            double y = Convert.ToDouble(numberTwo.Text);
            return x * y;
        }

        public string Div()
        {
            double x = Convert.ToDouble(numberOne.Text);
            double y = Convert.ToDouble(numberTwo.Text);
            if (y != 0)
                return $"{x / y}";
            else
                return "На ноль не делтся";
        }

        private void count_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Method = Convert.ToString(method.Text);
                switch (Method)
                {
                    case "+":
                        answer1.Content = Add();
                        break;
                    case "-":
                        answer1.Content = Sub();
                        break;
                    case "*":
                        answer1.Content = Mul();
                        break;
                    case "/":
                        answer1.Content = Div();
                        break;
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
