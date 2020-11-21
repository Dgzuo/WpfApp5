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

namespace WpfApp5
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = input.Text;
            int i = int.Parse(s);

            

            int first = i / 1000, second = i % 1000;

            

            int sum1 = 0, sum2 = 0;
            /*
             * 123      0 + 3 + 2 + 1
             * 123 % 10 = 3
             * 123 / 10
             * 12
             * 12 % 10 = 2
             * 12 / 10
             * 11 % 10 = 1
             * 1 / 10 = 0
             */
            while (first != 0)
            {
                sum1 += first % 10;
                first /= 10;
            }

            while (second != 0)
            {
                sum2 += second % 10;
                second /= 10;
            }

            if(sum1 == sum2)
            {
                label.Content =  $"число ({sum1},{sum2}) счастливое";
            } else
            {
                label.Content = $"число  ({sum1},{sum2}) несчастливое";
            }
        }


    }
}
