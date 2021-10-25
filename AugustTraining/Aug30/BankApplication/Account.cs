using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }

        public Account()
        {
            Balance = 5000;
            Type = "Not set yet";
        }

        public Account(string accountNumber, string name, double balance, string type, string phone)
        {
            AccountNumber = accountNumber;
            Name = name;
            Balance = balance;
            Type = type;
            Phone = phone;
        }
        public virtual bool Transact(string transType,double amount)
        {
            bool result = false;
            return result;
        }
        public void TakeAccountDetailsFromUser()
        {
            Console.WriteLine("Please enter the account number");
            AccountNumber = Console.ReadLine();
            Console.WriteLine("Please enter the account holder's name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the initial balance");
            Balance = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the contact number");
            Phone = Console.ReadLine();
        }
        public override string ToString()
        {
            return "Account number : " + AccountNumber
                + "\n Name : " + Name
                + "\n Balance : " + Balance
                + "\n Type : " + Type
               + "\n Contact Phone : " + Phone;
        }
    }
}