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

namespace TestRectungle
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

        private void result_Click(object sender, RoutedEventArgs e)
        {
            
            double num1, num2, num3;
            num1 = Convert.ToDouble(okno1.Text);
            num2 = Convert.ToDouble(okno2.Text);
            num3 = Convert.ToDouble(okno3.Text);
            
            if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
            {
                if (num1 == num2 && num1 == num3 && num3 == num1)
                {
                    Window window = new Window1();
                    window.Show();
                }
                else if (num1 == num2 && num1 != num3 || num2 == num3 && num3 != num1 || num1 == num3 && num3 != num2)
                {
                    Window window2 = new Window2();
                    window2.Show();
                }
                else if (num1 != num2 && num2 != num3 && num3 != num1)
                {
                    Window window3 = new Window3();
                    window3.Show();
                }
            }
            else
            {
                MessageBox.Show("Не является треугольником!");
            }
        } 
    }
}
