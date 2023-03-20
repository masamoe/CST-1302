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

namespace FinalWpfApp
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

        private void submit_btn_Click(object sender, RoutedEventArgs e)
        {
            int myNum = int.Parse(integer_in.Text);
            digit_number_out.Text = "Your number has " + numDigits(myNum) + " digits.";
            mostSignificant(myNum);
            leastSignificant(myNum);
            evenDigits(myNum);
            oddDigits(myNum);
            primeNumbers(myNum);
            thousandsPlace(myNum);
            hundredsPlace(myNum);
            tensPlace(myNum);
            onesPlace(myNum);

        }

        private int numDigits(int input)
        {
            int count = 0;
            while (input > 0)
            {
                input = input / 10;
                count++;
            }
            return count;
        }

        private void mostSignificant(int input)
        {
            int count = numDigits(input);
            int[] digits = new int[count];
            for (int i = 0; i < count; i++)
            {
                digits[i] = input % 10;
                input /= 10;
            }
            most_sig_out.Text = "The most significant digit is " + digits[count-1].ToString();
        }

        private void leastSignificant(int input)
        {
            int count = numDigits(input);
            int[] digits = new int[count];
            for (int i = 0; i < count; i++)
            {
                digits[i] = input % 10;
                input /= 10;
            }
            least_sig_out.Text = "The least significant digit is " + digits[0].ToString();
        }

        private void evenDigits(int input)
        {
            int count = numDigits(input);
            int[] digits = new int[count];
            for (int i = 0; i < count; i++)
            {
                digits[i] = input % 10;
                input /= 10;
            }
            int evenCount = 0;
            for (int i = 0; i < count; i++)
            {
                if (digits[i] % 2 == 0)
                {
                    evenCount++;
                }
            }
            even_out.Text = "There are " + evenCount.ToString() + " even digits.";
        }

        private void oddDigits(int input)
        {
            int count = numDigits(input);
            int[] digits = new int[count];
            for (int i = 0; i < count; i++)
            {
                digits[i] = input % 10;
                input /= 10;
            }
            int oddCount = 0;
            for (int i = 0; i < count; i++)
            {
                if (digits[i] % 2 != 0)
                {
                    oddCount++;
                }
            }
            odd_out.Text = "There are " + oddCount.ToString() + " odd digits.";
        }

        private void primeNumbers(int input)
        {
            int count = numDigits(input);
            int[] digits = new int[count];
            for (int i = 0; i < count; i++)
            {
                digits[i] = input % 10;
                input /= 10;
            }
            int primeCount = 0;
            for (int i = 0; i < count; i++)
            {
                int a = 0;
                for (int j = 1; j <= digits[i]; j++)
                {
                    if (digits[i] % j == 0)
                    {
                        a++;
                    }
                }
                if (a == 2)
                {
                    primeCount++;
                }
            }
            prime_out.Text = "There are " + primeCount.ToString() + " prime digits.";
        }

        private void thousandsPlace(int input)
        {
            int count = numDigits(input);
            int[] digits = new int[count];
            for (int i = 0; i < count; i++)
            {
                digits[i] = input % 10;
                input /= 10;
            }
            thou_out.Text = "It has " + digits[3].ToString() + " thousands.";
        }

        private void hundredsPlace(int input)
        {
            int count = numDigits(input);
            int[] digits = new int[count];
            for (int i = 0; i < count; i++)
            {
                digits[i] = input % 10;
                input /= 10;
            }
            hund_out.Text = "It has " + digits[2].ToString() + " hundreds.";
        }

        private void tensPlace(int input)
        {
            int count = numDigits(input);
            int[] digits = new int[count];
            for (int i = 0; i < count; i++)
            {
                digits[i] = input % 10;
                input /= 10;
            }
            ten_out.Text = "It has " + digits[1].ToString() + " tens.";
        }

        private void onesPlace(int input)
        {
            int count = numDigits(input);
            int[] digits = new int[count];
            for (int i = 0; i < count; i++)
            {
                digits[i] = input % 10;
                input /= 10;
            }
            one_out.Text = "It has " + digits[2].ToString() + " ones.";
        }
    }
}
