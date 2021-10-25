using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBankingApplication
{
    public class Bank
    {
        Account[] accounts;
        Transaction[] transactions;
        int MAX_SIZE = 5;
        int count, transCount;
        public Bank()
        {
            accounts = new Account[5];
            transactions = new Transaction[5];
            count = 0;
            transCount = 0;
        }

        public void AddAccounts()
        {
            string typeChoice;
            do
            {
                Console.WriteLine("Do you want to open a savings or current account??");
                Console.WriteLine("Key in 's' for saving and 'c' for current");
                Console.WriteLine("Please enter 'e' to stop");
                typeChoice = Console.ReadLine().ToLower();
                switch (typeChoice)
                {
                    case "s":
                        accounts[count] = new SavingsAccount();
                        break;
                    case "c":
                        accounts[count] = new CurrentAccount();
                        break;
                    case "e":
                        Console.WriteLine("We are done creating accounts");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again");
                        break;
                }
                if (accounts[count] != null)
                {
                    accounts[count].GetAccountDetailsFromUser();
                    count++;
                }
                else
                    continue;

            } while (count < MAX_SIZE && typeChoice != "e");
        }
        public void PrintAllAccountDetails()
        {
            for (int i = 0; i < count; i++)
            {
                PrintAccount(accounts[i]);
            }
        }
        public void PrintAccountByNumber()
        {
            Console.WriteLine("Please eneter the account number");
            string userAccountNumber = GetAccountNumberFromUser();
            Account account = GetAccountUsingNumber(userAccountNumber);
            if (account == null)
            {
                Console.WriteLine($"Invalid account number {userAccountNumber}. No account present with this number ");
                return;
            }
            PrintAccount(account);
        }
        Account GetAccountUsingNumber(string accountNumber)
        {
            Account account = null;
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].AccountNumber == accountNumber)
                {
                    account = accounts[i];
                    break;
                }
            }
            return account;
        }
        string GetAccountNumberFromUser()
        {

            string accNumber = Console.ReadLine();
            if (accNumber == "" || accNumber == null)
            {
                Console.WriteLine("Something Went wrong.Please enter again");
                GetAccountNumberFromUser();
            }
            return accNumber;
        }
        void PrintAccount(Account account)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine(account);
            Console.WriteLine("----------------------------");
        }
        public void Transact()
        {
            Transaction transaction = new Transaction();
            Console.WriteLine("Please enter the from account number");
            string fromAccount = GetAccountNumberFromUser();
            transaction.FromAccount = GetAccountUsingNumber(fromAccount);
            if (transaction.FromAccount == null)
            {
                Console.WriteLine("Invalid from account");
                return;
            }
            Console.WriteLine("Please enter the to account number");
            string toAccount = GetAccountNumberFromUser();
            transaction.ToAccount = GetAccountUsingNumber(toAccount);
            if (transaction.ToAccount == null)
            {
                Console.WriteLine("Invalid from account");
                return;
            }
            transaction.TransactionDate = DateTime.Today;
            Console.WriteLine("Please enter if it is credit or debit");
            string type = Console.ReadLine().ToLower();
            if (type == "credit")
            {
                CreditTransaction(transaction);
            }
            transactions[transCount] = transaction;
            transCount++;
        }
        void CreditTransaction(Transaction transaction)
        {
            transaction.Type = "credit";
            Console.WriteLine("Please enter the amount");
            double amount = Convert.ToDouble(Console.ReadLine());
            transaction.Amount = amount;
            if (transaction.FromAccount.CheckBalanceStatus(amount))
            {
                transaction.ToAccount.Balance += amount;
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Printing updated balance of from account");
                PrintAccount(transaction.FromAccount);
                transaction.Status = "Success";
            }
            else
            {
                Console.WriteLine("Insufficient balance. Transaction failed.");
                transaction.Status = "Failed due to lack of balance";

            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("The transaction details");
            Console.WriteLine(transaction);
            transaction.Id = transCount + 1;
        }
        public void PrintAllTranscations()
        {
            for (int i = 0; i < transCount; i++)
            {
                Console.WriteLine("*********************************");
                Console.WriteLine(transactions[i]);
                Console.WriteLine("*********************************");
            }
        }
    }
}
