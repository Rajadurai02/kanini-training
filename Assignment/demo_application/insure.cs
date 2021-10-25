using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_application
{
     public class insure
    {
        
        public string policynumber { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }
        public string Type { get; set; }

        public insure()
        {
            Type = "nsy";
        }

        public insure(string number, string name, string phone, string type)
        {
            policynumber = number;
            Name = name;
            Phone = phone;
            Type = type;
        }

       public  virtual bool  policy(string type)
        {

            bool result = false;
            return result;

        }

        public void TakePolicyDetailsFromUser()
        {
            Console.WriteLine("Please enter the policy number");
            policynumber = Console.ReadLine();
            Console.WriteLine("Please enter teh account holder's name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the phone");
            Phone = Console.ReadLine();
            Console.WriteLine("Please enter the type of insurance");
            Type = Console.ReadLine();
        }
    }
}
