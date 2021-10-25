using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Bank
    {
        Account[] accounts;
        public Bank()
        {
            accounts = new Account[3];
        }
        public void CreateAccounts()
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                accounts[i] = null;
                Console.WriteLine("Do you want a savings or a current account?");
                string type = Console.ReadLine();
                if(type=="saving")
                {
                    accounts[i] = new SavingsAccount();
                }
                else if(type == "current")
                {
                    accounts[i] = new CurrentAccount();
                }
                else
                {
                    Console.WriteLine("Invalid Entry. Please try again");
                    i = i - 1;
                    break;
                }
                accounts[i].TakeAccountDetailsFromUser();
            }
        }
        public void DoTransaction()
        {
            Console.WriteLine("Please enter you account number");
            string accNumber = Console.ReadLine();
            Account fromAccount = FindAccount(accNumber);
            if(fromAccount != null)
            {
                Console.WriteLine("Do u want to deboit or credit??");
                string type = Console.ReadLine();
                Console.WriteLine("Enter the target account number");
                accNumber = Console.ReadLine();
                Account  toAccount = FindAccount(accNumber);
                if(toAccount != null)
                {
                    if(type == "credit")
                    {
                        Console.WriteLine("Please enter the amount you wish to credit");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        if(fromAccount.Transact("Credit",amount))
                        {
                            toAccount.Balance += amount;
                        }
                        Console.WriteLine("The to account details after trasaction");
                        Console.WriteLine(toAccount);
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid traget account number");
                }
            }
            else
            {
                Console.WriteLine("Your account number is not valid");
            }
            Console.WriteLine("The from account details after teh transaction");
            Console.WriteLine(fromAccount);
            Console.WriteLine("-----------------------");
           
        }
        Account FindAccount(string accNumber)
        {
            Account account = null;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].AccountNumber == accNumber)
                {
                    account = accounts[i];
                    break;
                }
            }
            return account;
        }
    }
}