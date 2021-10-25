using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBankingApplication
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AccountType { get; set; }
        public string Phone { get; set; }

        public Account()
        {
            Balance = 5000;
        }
        public override bool Equals(object obj)
        {
            Account a1 = this;
            Account a2 = (Account)obj;
            if(a1.AccountNumber == a2.AccountNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Account(string accountNumber, string name, double balance, string phone)
        {
            AccountNumber = accountNumber;
            Name = name;
            Balance = balance;
            Phone = phone;
        }
        public void GetAccountDetailsFromUser()
        {
            Console.WriteLine("Please enter the account number");
            AccountNumber = Console.ReadLine();
            Console.WriteLine("Please enter the account holder's name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the initial balance");
            try
            {
                Balance = double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter the intial balance in numbers");
                Balance = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter the contact number");
            Phone = Console.ReadLine();
        }
        public override string ToString()
        {
            return "Account number : " + AccountNumber
                + "\nAccount Type : " + AccountType
                + "\nAccount Holder's Name : " + Name
                + "\nBalance : " + Balance           
                + "\nContact Phone Number : " + Phone;
        }
        public virtual bool CheckBalanceStatus(double amount)
        {
            bool result = false;
            return result;
        }
    }
   
}

