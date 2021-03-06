using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    public class Employee: IComparable<Employee>
    {
        int id, age;
        string name;
        double salary;
        public Employee()
        {
        }
        public Employee(int id, int age, string name, double salary)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.salary = salary;
        }
        /// <summary>
        /// function that gets inputs from the user
        /// </summary>
        public void TakeEmployeeDetailsFromUser()
        {
            Console.WriteLine("Please enter the employee ID");
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("The Employee Id must be Numbers");
                Console.WriteLine("Please enter again Correctly!");
                id = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            try 
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("The Age must be Numbers");
                Console.WriteLine("Please enter again Correctly!");
                age = Convert.ToInt32(Console.ReadLine());
            }         
            Console.WriteLine("Please enter the employee salary");
            try
            {
                salary = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("The Salary must be Numbers");
                Console.WriteLine("Please enter again Correctly!");
                salary = Convert.ToDouble(Console.ReadLine());
            }
            
        }
        /// <summary>
        /// overridden tostring method for printing employee deatils
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Employee ID : " + id + "\nName : " + name + "\nAge : " + age +
           "\nSalary : " + salary;
        }
        public int CompareTo(Employee emp)
        {
            return this.Salary.CompareTo(emp.Salary);
        }

        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}
