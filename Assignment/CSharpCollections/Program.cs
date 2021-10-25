using System;

namespace CSharpCollections
{
    public class Program
    {
        EmployeeDetails employeeDetails;
        public Program()
        {
            employeeDetails = new EmployeeDetails();
        }
        /// <summary>
        /// Menulist used adding , modifiying or removing a employee details
        /// </summary>
        public void MenuList()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("1. Add Employee\n2. Modify Employee Details\n3. Print Employee Details\n4. Delete Employee\n5. Exit");
                Console.WriteLine("Please select the any above option!");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please enter a option 1 - 5");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                switch (choice)
                {
                    case 1:
                        employeeDetails.AddEmployee();
                        break;
                    case 2:
                        employeeDetails.ModifyEmployee();
                        break;
                    case 3:
                        employeeDetails.PrintEmployeeById();
                        break;
                    case 4:
                        employeeDetails.DeleteEmployee();
                        break;
                    case 5:
                        Console.WriteLine("You Selected Exit!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option!. Please try again");
                        break;
                }
            } while (choice != 5);

        }
        static void Main(string[] args)
        {
            //new Program().MenuList();
            //DictionaryEmployees dictEmp = new DictionaryEmployees();
            //dictEmp.AddEmployeeDetailsInDictionary();
            //dictEmp.getEmployeeDetailsUsingDict();
            EmployeeDetails emp = new EmployeeDetails();
            emp.SomeEmployeedata();
            //emp.EmployeeSortingBasesSalary();
            //emp.PrintEmployeeDetailsUsingLINQWhere();
            //emp.PrintEmployeeByName();
            //emp.PrintOlderEmployee();
            emp.PrintAllEmployeeDetails();
            Console.ReadKey();
        }
    }
}
