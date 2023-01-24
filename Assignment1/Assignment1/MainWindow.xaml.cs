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

namespace Assignment1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double num1;
        double num2;
        double result;
        
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void AddNums(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(number1.Text);
            num2 = Convert.ToDouble(number2.Text);
            result = num1 + num2;
            resultBox.Text = result.ToString();
        }
    }
}
