using System;
using System.Collections.Generic;
using System.Linq;

namespace EFExampleFramework
{
    class Program
    {
        CompanyContext companycontext;
        public Program()
        {
            companycontext = new CompanyContext();
        }
        public void PrintAllEmployeeDetails()
        {
            List<Employee> employees = companycontext.Employees.ToList();
            foreach (var item in employees)
            {
                Console.WriteLine("Employee ID: " + item.Id);
                Console.WriteLine("Employee Name: " + item.Name);
                Console.WriteLine("Employee Age: " + item.Age);
                Console.WriteLine("-------------------------");
            }
        }
        public void AddEmployee()
        {
            Employee employee = new Employee();
            Console.WriteLine("Please Enter the Employee Name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Please Enter the Employee Age");
            employee.Age = Convert.ToInt32(Console.ReadLine());
            companycontext.Employees.Add(employee);
            companycontext.SaveChanges();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.AddEmployee();
            program.PrintAllEmployeeDetails();
            Console.ReadKey();
        }
    }
}
