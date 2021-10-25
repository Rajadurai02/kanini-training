using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class DictionaryEmployees
    {
        Dictionary<int, Employee> DictEmployees = new Dictionary<int, Employee>();
        /// <summary>
        /// Dictionary that holdes the employee details
        /// </summary>
        public void AddEmployeeDetailsInDictionary()
        {
            
            DictEmployees.Add(1001, new Employee(1001, 21, "Raja", 30000));
            DictEmployees.Add(1002, new Employee(1002, 22, "Bala", 40000));
            DictEmployees.Add(1003, new Employee(1003, 25, "Vijay", 35000));
            DictEmployees.Add(1004, new Employee(1004, 23, "Prakash", 38000));
            DictEmployees.Add(1005, new Employee(1005, 24, "Suriya", 80000));
        }
        /// <summary>
        /// retriving particular employee detail from using dictionary
        /// </summary>
        public void getEmployeeDetailsUsingDict()
        {
            int EmpID;
            Console.WriteLine("Print Employee Details Using Dictionary");
            Console.WriteLine("Enter the EmployeeID or Key for the Employer details you want");
            try
            {
                EmpID = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter Employee ID in numbers");
                EmpID = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var key in DictEmployees.Keys)
            {
                if (key == EmpID)
                {
                    Console.WriteLine(DictEmployees[key]);
                }
            }
        }
    }
}
