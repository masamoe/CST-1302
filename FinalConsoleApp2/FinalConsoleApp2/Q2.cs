class Program
{
    abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() 
        {
            Name= string.Empty;
            Age= 0;
        }

        public abstract double getSalary();
    }

    class Employee:Person
    {
        public double PayRate { get; set; }
        public int Hours { get; set; }

        public Employee(string name, int age, double payRate, int hours)
        {
            Name= name;
            Age= age;
            PayRate= payRate;
            Hours= hours;
        }

        public override double getSalary()
        {
            return PayRate*Hours;
        }
    }

    static void Main(string[] args)
    {
        Employee john = new Employee("John", 35, 26.5, 42);

        Console.WriteLine("Name: "+ john.Name);
        Console.WriteLine("Age: " + john.Age);
        Console.WriteLine("Pay Rate: " + john.PayRate);
        Console.WriteLine("Hours: " + john.Hours);
        Console.WriteLine("Salary: " + john.getSalary());
    }
}