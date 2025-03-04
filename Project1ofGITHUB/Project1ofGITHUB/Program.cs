// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibManagementSystem
{
    using System;
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public double Price;
        public Book(string title, string author, string isbn, double price)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Price = price;
        }
        public void DisplayBookInfo()
        {
            Console.WriteLine("Book Details:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Price: ${Price:F2}");
        }
        public void ApplyDiscount(double percentage)
        {
            Price -= Price * (percentage / 100);
            Console.WriteLine($"New price after {percentage}% discount: ${Price:F2}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Book myBook = new Book("Buried Hearts", "F.Scott", "9780743275", 15.99);

            myBook.DisplayBookInfo();

            myBook.ApplyDiscount(10);

            myBook.DisplayBookInfo();
        }
    }

}




using System;
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

