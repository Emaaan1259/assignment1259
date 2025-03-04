// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;

Console.WriteLine("Hello, World!");

sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    using System;
    public class Employee
    {
        public int EmployeeID;
        public string Name;
        public string Department;
        public double Salary;
        public Employee(int employeeID, string name, string department, double salary)
        {
            EmployeeID = employeeID;
            Name = name;
            Department = department;
            Salary = salary;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Salary: {Salary:C}");
        }
        public void IncreaseSalary(double amount)
        {
            Salary += amount;
            Console.WriteLine($"Salary increased by {amount:C}. New salary is {Salary:C}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "Imaan", "AI", 65000);

            emp1.DisplayEmployeeDetails();

            emp1.IncreaseSalary(5000);

            emp1.DisplayEmployeeDetails();
        }
    }

}
