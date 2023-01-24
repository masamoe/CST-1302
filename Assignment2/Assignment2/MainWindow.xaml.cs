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

namespace Assignment2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Random_Number();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double number = Convert.ToDouble(randomNum.Text);
            if (guess.Text == "even" && number % 2 == 0)
            {
                answer.Content = "Correct";
            }
            else if (guess.Text == "odd" && number % 2 != 0)
            {
                answer.Content = "Correct";
            }
            else
            {
                answer.Content = "Incorrect";
            }
            Random_Number();
        }
        
        public void Random_Number()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            randomNum.Text = randomNumber.ToString();
        }
    }
}
