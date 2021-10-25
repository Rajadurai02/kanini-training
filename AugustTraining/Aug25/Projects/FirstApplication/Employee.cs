using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime DOB { get; set; }
        void GetEmployeeDetails()
        {
            Console.WriteLine("please enter your employee Id");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter your employee Name");
            Name = Console.ReadLine();
            Console.WriteLine("please enter your salary");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter your employee DOB");
            DOB = Convert.ToDateTime(Console.ReadLine());

        }
        void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee Id: " + Id);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Salary: " + Salary ); 
            Console.WriteLine("Employee DOB: " + DOB);
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.GetEmployeeDetails();
            emp.PrintEmployeeDetails();
            Console.ReadKey();
        }
    }
}
