using EFBankingApplication.Models;
using System;

namespace EFBankingApplication
{
    class Program
    {
        BankContext context;
        Bank bank;
        public Program()
        {
            context = new BankContext();
            bank = new Bank();
        }
        public void MenuList()
        {
            Console.WriteLine("----- BANKING APPLICATION -----");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1. Create Accounts");
            Console.WriteLine("2. Delete Account");
            Console.WriteLine("3. Print all account's details");
            Console.WriteLine("4. Print details of an account");
            Console.WriteLine("5. Transact");
            Console.WriteLine("6. Print all transaction details");
            Console.WriteLine("0. Exit\n");
        }
        void printMenu()
        {
            int choice = 0;
            do
            {
                MenuList();
                Console.WriteLine("Enter your choice");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please enter NUmbers 0-6 only");
                    printMenu();
                }
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("You selected to exit!. Bye");
                        break;
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DeleteAccount();
                        break;
                    case 3:
                        PrintAllAccountDetails();
                        break;
                    case 4:
                        GetAccountByAccNo();
                        break;
                    case 5:
                        //Transact();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Invalid Option. Please try Again");
                        break;
                }
            } while (choice != 0);
        }

    void AddAccount()
            {
            Account account = new Account();
            Console.WriteLine("--- ADD ACCOUNT TO DATABASE ---");
            string type;
            do
            {
                Console.WriteLine("Enter the Account Type 's for Savings' or 'c for Current'");
                type = Console.ReadLine().ToLower();
                if (type == "s")
                    account.AccountType = "Savings";
                else if (type == "c")
                    account.AccountType = "Current";
                else
                    Console.WriteLine("Please enter correct type");
            } while (type != "s" && type != "c");
            Console.WriteLine("Enter the Account Number");
            account.AccountNumber = Console.ReadLine();
            Console.WriteLine("Enter the Account Holder Name");
            account.Name = Console.ReadLine();
            Console.WriteLine("Enter the Initial Balance");
            try
            {
                account.Balance = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter Balance in Numbers");
                account.Balance = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the phone Number");
            account.Phone = Console.ReadLine();
            context.Accounts.Add(account);
            context.SaveChanges();
            Console.WriteLine("\nAccount Successfully Added to Database!!");
        }
        void DeleteAccount()
        {
            Console.WriteLine("--- DELETE ACCOUNT FROM DATABASE ---");
            Console.WriteLine("Enter The Account Number of Account you want Delete");
            string AccNo;
            AccNo = Console.ReadLine();
            try
            {
                var idx = context.Accounts.Find(AccNo);
                context.Accounts.Remove(idx);
                context.SaveChanges();
                Console.WriteLine("account deleted");
            }
            catch (Exception )
            {
                Console.WriteLine($"There is no Account Number {AccNo} in the database");
            }           
            
        }
        void ModifyAccount()
        {
            Console.WriteLine("--- DELETE ACCOUNT FROM DATABASE ---");
            Console.WriteLine("Enter The Account Number of Account you want modify");
            string AccNo;
            AccNo = Console.ReadLine();
            try
            {
                var idx = context.Accounts.Find(AccNo);
                idx.Balance += 5000; 
                context.Accounts.Update(idx);
                context.SaveChanges();
            }
            catch (Exception)
            {
                Console.WriteLine($"There is no Account Number {AccNo} in the database");
            }

        }
        void PrintAllAccountDetails()
        {
            Console.WriteLine("--- ALL ACCOUNT DETAILS ---");
            foreach (var item in context.Accounts)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Account Number : "+item.AccountNumber);
                Console.WriteLine("Account Holder Name : " + item.Name);
                Console.WriteLine("Account Type : " + item.AccountType);
                Console.WriteLine("Balance : " + item.Balance);
                Console.WriteLine("Phone Number : " + item.Phone);
            }
        }
        void GetAccountByAccNo()
        {
            Console.WriteLine("--- PRINT ACCOUNT FROM DATABASE ---");
            Console.WriteLine("Enter The Account Number of Account you want to print");
            string AccNo;
            AccNo = Console.ReadLine();
            try
            {
                var idx = context.Accounts.Find(AccNo);
                Console.WriteLine("-------------------------");
                Console.WriteLine("Account Number : " + idx.AccountNumber);
                Console.WriteLine("Account Holder Name : " + idx.Name);
                Console.WriteLine("Account Type : " + idx.AccountType);
                Console.WriteLine("Balance : " + idx.Balance);
                Console.WriteLine("Phone Number : " + idx.Phone);
            }
            catch (Exception )
            {
                Console.WriteLine($"There is no Account Number {AccNo} in the database");
            }
        }
        static void Main(string[] args)
        {
            //new Program().printMenu();
            new Program().ModifyAccount();
            Console.ReadKey();
        }
    }
}
