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

namespace MidTerm
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

        private void Convert_btn_Click(object sender, RoutedEventArgs e)
        {
            int amount = int.Parse(Amount_in.Text);
            double[] rates = { 1.3335071, 1.4300309, 0.92882028, 0.010070252, 1};
            double fromRate = rates[From_box.SelectedIndex];
            double toRate = rates[To_box.SelectedIndex];
            double result = Math.Round(amount * fromRate / toRate, 2);

            Amount_out.Text = result.ToString();
        }
    }
}
