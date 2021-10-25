using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApplication
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Strength { get; set; }
        public void PrintDeptDetails()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("DEPARTMENT DETAILS");
            Console.WriteLine("Department ID: " + Id);
            Console.WriteLine("Department Name: " + Name);
            Console.WriteLine("Department Strength: " + Strength);
        }
        public void AddEmployee()
        {
            string Empname, Deptname;
            DateTime DOJ;
            Console.WriteLine("ADDING EMPLOYEE ......");
            Console.WriteLine("Enter the employee name");
            Empname = Console.ReadLine();
            Console.WriteLine("Enter the department name ");
            Deptname = Console.ReadLine();
            Console.WriteLine("Enter the date of joining ");
            DOJ = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Employee datails Successfully Added!");
            Console.WriteLine("----------------------");
            Console.WriteLine("Employee Name: " + Empname);
            Console.WriteLine("Department Name: " + Deptname);
            Console.WriteLine("Date of Joining: " + DOJ);
            Console.WriteLine("----------------------");
        }
        public void RelieveEmployee()
        {
            string DismissReason,Empname;
            DateTime DateOfDismiss;
            Console.WriteLine("EMPLOYEE RELIEVE.......");
            Console.WriteLine("Enter the employee name");
            Empname = Console.ReadLine();
            Console.WriteLine("Enter the dismiss reason");
            DismissReason = Console.ReadLine();
            Console.WriteLine("Enter the date of dismiss ");
            DateOfDismiss = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine("Employee Name: " + Empname);
            Console.WriteLine("Reason for Dismiss: " + DismissReason);
            Console.WriteLine("Date of Dismiss: " + DateOfDismiss);

        }
        
        static void Main(string[] args)
        {
            Department dept = new Department();
            dept.Id = 1001;
            dept.Name = "Human Resource";
            dept.Strength = "A Successful Employement branding";
            dept.PrintDeptDetails();
            dept.AddEmployee();
            dept.RelieveEmployee();
            Console.ReadKey();
        }
    }
}
