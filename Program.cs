using System;

namespace EmployeeSalary
{
    class Employee
    {
        string name, designation;
        int experience;
        double Salary, insurance;
        public Employee(string name, string designation, int experience, double Salary, double insurance)
        {
            this.name = name;
            this.designation = designation;
            this.experience = experience;
            this.Salary = Salary;
            this.insurance = insurance;
        }

        public double salary()
        {
            double hra = (20/100)* Salary;
            double ta = (10/100)* Salary;
            double grosspay = Salary + hra + ta - insurance;
            return grosspay;
        }

        public void display()
        {
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Experience: " + experience);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Insurance: " + insurance);
            Console.WriteLine("Gross Pay: " + salary());
        }
    }

    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Enter employee name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter designation: ");
            string designation = Console.ReadLine();

            Console.WriteLine("Enter years of experience: ");
            int experience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter salary: ");
            double Salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter insurance: ");
            double insurance = Convert.ToDouble(Console.ReadLine());
            
            Employee employee = new Employee(name, designation, experience, Salary, insurance);
            employee.display();
        }
    }
    
}