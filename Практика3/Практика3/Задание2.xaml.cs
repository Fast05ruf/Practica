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
    /// Логика взаимодействия для Задание2.xaml
    /// </summary>
    public partial class Задание2 : Window
    {
        public Задание2()
        {
            InitializeComponent();
        }
        double operand1 = 2;
        double operand2 = 3;
        string sign = "";

        private void Slo_Click(object sender, RoutedEventArgs e)
        {
            string sign = Convert.ToString(C.Text);
            switch (sign)
            {
                case "+":
                    l1.Content = (operand1 + operand2);
                    break;
                case "-":
                    l1.Content = (operand1 - operand2);
                    break;
                case "*":
                    l1.Content = (operand1 * operand2);
                    break;
                case "/":
                    l1.Content = Math.Round(operand1 / operand2,4);
                    break;
                case "^":
                    l1.Content = Math.Pow(operand1, operand2);
                    break;
                default:
                    MessageBox.Show("Неверный формат данных.");
                    break;
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
