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

namespace Assignment3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void YourName_TextChanged(object sender, TextChangedEventArgs e)
        {
            NameSummary.Content = "Your name is "+YourName.Text;
        }

        private void YourAge_TextChanged(object sender, TextChangedEventArgs e)
        {
            AgeSummary.Content = "Your age is " + YourAge.Text;
        }

        private void Black_Checked(object sender, RoutedEventArgs e)
        {
            HairSummary.Content = "Your hair color is black";
        }

        private void White_Checked(object sender, RoutedEventArgs e)
        {
            HairSummary.Content = "Your hair color is white";
        }

        private void Brown_Checked(object sender, RoutedEventArgs e)
        {
            HairSummary.Content = "Your hair color is brown";
        }

        private void CheckBox_Checked()
        {
            if (Red.IsChecked == true && Green.IsChecked == true && Blue.IsChecked == true)
            {
                ColourSummary.Content = "Your favorite color is red, green, and blue";
            }
            else if (Red.IsChecked == true && Green.IsChecked == true)
            {
                ColourSummary.Content = "Your favorite color is red and green";
            }
            else if (Red.IsChecked == true && Blue.IsChecked == true)
            {
                ColourSummary.Content = "Your favorite color is red and blue";
            }
            else if (Green.IsChecked == true && Blue.IsChecked == true)
            {
                ColourSummary.Content = "Your favorite color is green and blue";
            }
            else if (Red.IsChecked == true)
            {
                ColourSummary.Content = "Your favorite color is red";
            }
            else if (Green.IsChecked == true)
            {
                ColourSummary.Content = "Your favorite color is green";
            }
            else if (Blue.IsChecked == true)
            {
                ColourSummary.Content = "Your favorite color is blue";
            }
            else
            {
                ColourSummary.Content = " ";
            }
        }

        private void Red_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox_Checked();
        }

        private void Green_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox_Checked();
        }

        private void Blue_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox_Checked();
        }
    }
}
