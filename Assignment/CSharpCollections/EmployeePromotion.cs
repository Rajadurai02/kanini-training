using System;
using System.Collections.Generic;


namespace CSharpCollections
{
    class EmployeePromotion
    {
        //list for storing employee names
        List<string> EmployeeNames = new List<string>();
        /// <summary>
        /// Geting Employee names from the user for their order of eligibility
        /// </summary>
       public void GetEmployeeNamesInOrderOfEligibility()
        {
            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion(Please enter blank to stop)");
            string name;
            //user enter a blank it stops getting input
            do
            {
                name = Console.ReadLine();
                if (name != "")
                {
                    //add the name to EmployeeNames list
                    EmployeeNames.Add(name);
                }
            } while (name != "");
        }
        //print particluar employees promotion position
        public void PrintEmployeePromotionPosition()
        {
            EmployeeNames.Clear();
            //calling the GetEmployeeNamesInOrderOfEligibility() to get the input from the user
            GetEmployeeNamesInOrderOfEligibility();
            string EmpName;
            //geting the employer who need their promotion
            Console.WriteLine("Please enter the name of the employee to check promotion position");
            EmpName = Console.ReadLine();
            //if the name not present in the list print the name not in the list
            if (EmployeeNames.Contains(EmpName) == false)
            {
                Console.WriteLine("The name you entered not found in the List");
            }
            //using indexof method to find the position and print the position
            Console.WriteLine($"'{EmpName}' is the position {EmployeeNames.IndexOf(EmpName) + 1} for promotion ");
        }
        /// <summary>
        /// prints the capacity of the list before and after removing extra spaces
        /// </summary>
        public void PrintSizeOfCollection()
        {
            EmployeeNames.Clear();
            GetEmployeeNamesInOrderOfEligibility();
            int MemorySize;
            //get the capacity of the EmployeeNames list
            MemorySize = EmployeeNames.Capacity;
            Console.WriteLine($"The current size of collection is {MemorySize}");
            //using TrimExcess to remove the extra space
            EmployeeNames.TrimExcess();
            MemorySize = EmployeeNames.Capacity;
            //printing the capacity after removing the extra space
            Console.WriteLine($"The size after removing the extra space is  {MemorySize}");
        }
        /// <summary>
        /// printing Employee Names in Ascending order
        /// </summary>
        public void PrintEmployeeNamesOnAscendingOrder()
        {
            EmployeeNames.Clear();
            GetEmployeeNamesInOrderOfEligibility();
            //Using sort function to sort a list
            EmployeeNames.Sort();
            Console.WriteLine("Promoted Employee List");
            //print sorted employee names in ascending order
            foreach (var empName in EmployeeNames)
            {
                Console.WriteLine(empName);
            }
        }
        static void Main(string[] args)
        {

            EmployeePromotion emp = new EmployeePromotion();
            emp.GetEmployeeNamesInOrderOfEligibility();
            emp.PrintEmployeePromotionPosition();
            emp.PrintSizeOfCollection();
            emp.PrintEmployeeNamesOnAscendingOrder();
            Console.ReadKey();
        }
    }
}
