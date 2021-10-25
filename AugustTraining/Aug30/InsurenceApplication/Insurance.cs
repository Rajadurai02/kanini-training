using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurenceApplication
{
    class Insurance
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double InsuranceAmount { get; set; }       
        public string Phone { get; set; }

        public Insurance()
        {
            Type = "Not set yet";
        }

        public Insurance(string name, string type, double insuranceAmount, string phone)
        {
            Name = name;
            Type = type;
            InsuranceAmount = insuranceAmount;
            Phone = phone;
        }

        public virtual bool CalculatePremium(string Type, double InsuranceAmount)
        {
            bool result = false;
            return result;
        }
        public void GetPloicyHolderDetailsFromUser()
        {
            Console.WriteLine("Please enter the Policy holder's name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the insurance Amount");
            InsuranceAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the contact number");
            Phone = Console.ReadLine();
        }
        public override string ToString()
        {
            return  "\n Name : " + Name
                + "\n InsuranceAmount : " + InsuranceAmount
                + "\n Type : " + Type
               + "\n Contact Phone : " + Phone;
        }
    }
}
