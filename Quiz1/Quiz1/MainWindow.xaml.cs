using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Quiz1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Student newStudent;
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string[] Hobbies { get; set; }

            public Student(string name, int age, string[] hobbies)
            {
                Name = name;
                Hobbies = hobbies;
                Age = age;
            }
        
            public Student()
            {
                Name = "John Doe";
                Hobbies = new string[] { "Reading", "Writing", "Drawing" };
                Age = 18;
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static bool IsPalindrome(string myString)
        {
            string[] nameArr = myString.Split(' ');
            string firstName = nameArr[0].ToUpper();
            int length = firstName.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (firstName[i] != firstName[length - i - 1])
                    return false;
            }
            return true;
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            newStudent = new Student(NameIn.Text, int.Parse(AgeIn.Text), HobbiesIn.Text.Split(','));
            MessageBox.Show("Student object created.");
        }

        private void DisplayBtn_Click(object sender, RoutedEventArgs e)
        {
            string prime = "is not ";
            string palindrome = "is not ";

            if (IsPrime(newStudent.Age))
            {
                prime = "is ";
            }

            if (IsPalindrome(newStudent.Name))
            {
                palindrome = "is ";
            }

            NameOut.Text = "Name: "+newStudent.Name;
            AgeOut.Text = "Age: " + newStudent.Age.ToString();
            HobbyNumOut.Text = "Number of Hobbies: " + newStudent.Hobbies.Length.ToString();
            FirstHobbyOut.Text = "First Hobby: " + newStudent.Hobbies[0];
            LastHobbyOut.Text = "Last Hobby: " + newStudent.Hobbies[newStudent.Hobbies.Length - 1];
            PrimeTxt.Text = "Age " + prime + "a prime number.";
            PalindromeTxt.Text = "First name " + palindrome + "a palindrome.";
        }
    }
}
