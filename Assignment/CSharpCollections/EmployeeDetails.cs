using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    public class EmployeeDetails
    {
        List<Employee> employees;
        int count;
        public EmployeeDetails()
        {
            employees = new List<Employee>();
            count = 0;
        }
        /// <summary>
        /// Adding some default data to the list
        /// </summary>
        public void SomeEmployeedata()
        {
            employees.Add(new Employee()
            { Id = 1001, Age = 21, Name = "Tom", Salary = 20000 });
            employees.Add(new Employee()
            { Id = 1002, Age = 25, Name = "Jack", Salary = 40000 });
            employees.Add(new Employee()
            { Id = 1003, Age = 22, Name = "Anna", Salary = 30000 });
            employees.Add(new Employee()
            { Id = 1004, Age = 28, Name = "Clarke", Salary = 25000 });
        }
        /// <summary>
        /// function used for adding additional employee data
        /// </summary>
        public void AddEmployee()
        {
            employees.Add(new Employee());
            employees[employees.Count - 1].TakeEmployeeDetailsFromUser();
            count++;
        }
        /// <summary>
        /// function that retrive the all employee data
        /// </summary>
        public void PrintAllEmployeeDetails()
        {
            foreach (var item in employees)
            {
                PrintEmployee(item);
            }
        }
        /// <summary>
        /// printing a particular employee data
        /// </summary>
        /// <param name="employee"></param>
        void PrintEmployee(Employee employee)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine(employee);
            Console.WriteLine("----------------------------");
        }
        /// <summary>
        /// Method used for modifying the existing data
        /// </summary>
        public void ModifyEmployee()
        {
            Console.WriteLine("Please enter the Employee Id");
            int EmpId = getEmployeeIdFromUser();
            Employee employee = GetEmployeeUsingEmpId(EmpId);
            if (employee == null)
            {
                Console.WriteLine($"Invalid Employee Id {EmpId}.No such employee id such that");
            }
            else
            {
                Console.WriteLine("Please enter the name to be changed");
                employee.Name = Console.ReadLine();
                Console.WriteLine("Please enter the Age to be changed");
                try
                {
                    employee.Age = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("The Age must be in Numbers.");
                    Console.WriteLine("Please enter Correct format!");
                    employee.Age = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Please enter the Salary to be changed");
                try
                {
                    employee.Salary = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("The Salary must be in Numbers.");
                    Console.WriteLine("Please enter Correct format!");
                    employee.Salary = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("Employee Details successfully Modified.");
                Console.WriteLine("Select print option to see the modification");
            }
        }
        
        /// <summary>
        /// method for geting empId from user
        /// </summary>
        /// <returns></returns>
        int getEmployeeIdFromUser()
        {
            int EmpId = 0;
            try
            {
                EmpId = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a employee id in number format");
                getEmployeeIdFromUser();
            }
            return EmpId;
        }
        /// <summary>
        /// returning employee for particular employeeId
        /// </summary>
        /// <param name="EmpId"></param>
        /// <returns></returns>
        Employee GetEmployeeUsingEmpId(int EmpId)
        {
            Employee employee = null;
            if (employees.Count > 0)
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    if (employees[i].Id == EmpId)
                    {
                        employee = employees[i];
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("There is no Employee details in the List");
            }
            return employee;
        }
        /// <summary>
        /// Method for printing employee data using empId
        /// </summary>
        public void PrintEmployeeById()
        {
            Console.WriteLine("Please enter the Employee Id");
            int EmpId = getEmployeeIdFromUser();
            Employee employee = GetEmployeeUsingEmpId(EmpId);
            if (employee == null)
            {
                Console.WriteLine($"Invalid Employee Id {EmpId}.No such employee id such that");
            }
            PrintEmployee(employee);
        }
        /// <summary>
        /// Method for printing employee data using employee name
        /// </summary>
        public void PrintEmployeeByName()
        {
            string EmpName ;
            Employee emp = null;
            Console.WriteLine("Print Employee Details by Employee Name");
            Console.WriteLine("Enter the Employee Name");
            EmpName = Console.ReadLine();
            if (employees.Count > 0)
            {
                for (int i = 0; i < employees.Count; i++)
                {
                if (employees[i].Name == EmpName)
                {
                    emp = employees[i];
                    break;
                }
                }
            }
            else
            {
                Console.WriteLine("There is no Employee details in the List");
            }
            if (emp == null)
            {
                Console.WriteLine($"Invalid Employee Name {EmpName}.No such employee id such that");
            }
            PrintEmployee(emp);
        }
        /// <summary>
        /// method that printing older employee details comapared to the user entered employee
        /// </summary>
        public void PrintOlderEmployee()
        {
            string EmpName;
            Employee emp = null;
            Console.WriteLine("Enter the Employee Name who Age is younger");
            EmpName = Console.ReadLine();
            int age = 0;
            if (employees.Count > 0)
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    if (employees[i].Name == EmpName)
                    {
                        age = employees[i].Age;
                        emp = employees[i];
                        break;
                    }
                }
                Console.WriteLine($"Employees Older than {EmpName} are");
                foreach (var empAge in employees)
                {
                    if (empAge.Age > age)
                    {
                        PrintEmployee(empAge);
                    }
                }
            }
            else
            {
                Console.WriteLine("There is no Employee details in the List");
            }
            if (emp == null)
            {
                Console.WriteLine($"Invalid Employee Name {EmpName}.No such employee Name such that");
            }
            
        }
        /// <summary>
        /// Delete a particular employee from the list
        /// </summary>
        public void DeleteEmployee()
        {
            Console.WriteLine("Please enter the Employee Id");
            int EmpId = getEmployeeIdFromUser();
            Employee employee = GetEmployeeUsingEmpId(EmpId);
            if (employee == null)
            {
                Console.WriteLine($"Invalid Employee Id {EmpId}.No such employee id such that");
            }
            else
            {
                Console.WriteLine($"Employee {employee.Id} is removed from the List");
                employees.Remove(employee);
                
            }
        }
        /// <summary>
        /// sorting the employee list based on the salary
        /// </summary>
        public void EmployeeSortingBasesSalary()
        {
            employees.Sort();
            Console.WriteLine("Employee details After sorting Salary");
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
                Console.WriteLine("-------------------------");
            }
        }
        /// <summary>
        /// get employee details using LINQ where clause
        /// </summary>
        public void PrintEmployeeDetailsUsingLINQWhere()
        {
            int EmpId;
            Console.WriteLine("Using LINQ Where to find Employee Details");
            Console.WriteLine("Enter the employeeID of the Employee");
            try
            {
                EmpId = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter EmployeeId in correct format");
                EmpId = Convert.ToInt32(Console.ReadLine());
            }
            IEnumerable<Employee> EmployeeDetail = employees.Where(employee => employee.Id == EmpId);
            Console.WriteLine(EmployeeDetail);
        }
    }
}
