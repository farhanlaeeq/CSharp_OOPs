using System;
using System.Collections.Generic;

namespace CSharp_OOPs
{
    // Base class
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {this.Name}, Age: {this.Age}, Married: {this.IsMarried}");
        }
    }

    // Derived class
    class Employee : Person
    {
        public string EmployeeCode { get; set; }
        public string DepartmentCode { get; set; }
        public int Salary { get; set; }
        public bool IsActive { get; set; }

        public Employee(string name, int age, bool isMarried, string empCode, string deptCode, int salary, bool isActive)
        {
            this.Name = name;
            this.Age = age;
            this.IsMarried = isMarried;
            this.EmployeeCode = empCode;
            this.DepartmentCode = deptCode;
            this.Salary = salary;
            this.IsActive = isActive;
        }

        // Polymorphism: overriding method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Employee Code: {this.EmployeeCode}, Dept: {this.DepartmentCode}, Salary: {this.Salary}, Active: {this.IsActive}");
        }

        public void GiveRaise(int amount)
        {
            Salary += amount;
            Console.WriteLine($"{this.Name} got a raise of {amount}. New Salary: {this.Salary}");
        }

        public void GetBasicInfo()
        {
            Console.WriteLine($"{this.Name} of age: {this.Age}. IsMarried: {this.IsMarried}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();

            // Add employees
            employeeList.Add(new Employee("Alice", 30, true, "E001", "HR", 60000, true));
            employeeList.Add(new Employee("Bob", 26, false, "E002", "IT", 75000, true));

            Console.WriteLine("Employee Details:\n");

            foreach (var emp in employeeList)
            {
                emp.DisplayInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Giving a raise to Alice...\n");
            employeeList[0].GiveRaise(5000);

            Console.WriteLine("Updated Employee Info:\n");
            employeeList[0].DisplayInfo();

            Console.ReadLine();
        }
    }
}
