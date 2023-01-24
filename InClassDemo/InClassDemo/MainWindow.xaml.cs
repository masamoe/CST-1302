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

namespace InClassDemo
{
    public struct CarInfo
    {
        public string model;
        public int year;
        public double price;
    }
    public class Car
    {
        private CarInfo myCarInfo;
        private string carDealer;

        public CarInfo getCarInfo()
        {
            return myCarInfo;
        }

        public string getCarDealer()
        {
            return carDealer;
        }
        public Car() { }

        public Car(CarInfo myCarInfo, string carDealer)
        {
            this.myCarInfo = myCarInfo;
            this.carDealer = carDealer;
        }

        public Car(string model, int year, double price, string carDealer)
        {
            myCarInfo.model = model;
            myCarInfo.year = year;
            myCarInfo.price = price;
            this.carDealer = carDealer;
        }

    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Car myCar;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerateObject_Click(object sender, RoutedEventArgs e)
        {
             myCar = new Car(boxModel.Text, int.Parse(boxYear.Text), double.Parse(boxPrice.Text), boxDealer.Text);
        }

        private void btnDisplayObject_Click(object sender, RoutedEventArgs e)
        {
            blkModel.Text = myCar.getCarInfo().model;
            blkYear.Text = myCar.getCarInfo().year.ToString();
            blkPrice.Text = myCar.getCarInfo().price.ToString();
            blkDealer.Text = myCar.getCarDealer();
        }
    }
}
