using System;

namespace CRUDBankingApplication
{
    public class Program
    {
        Bank bank;
        public Program()
        {
            bank = new Bank();
        }
        void printMenu()
        {
            int choice;
            do
            {
                MenuList();
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("You selected to exit!. Bye");
                        break;
                    case 1:
                        bank.AddAccounts();
                        break;
                    case 2:
                        bank.PrintAllAccountDetails();
                        break;
                    case 3:
                        bank.PrintAccountByNumber();
                        break;
                    case 4:
                        bank.Transact();
                        break;
                    case 5:
                        bank.PrintAllTranscations();
                        break;
                    default:
                        Console.WriteLine("Invalid Option. Please try Again");
                        break;
                }
            } while (choice != 0);
        }
        void MenuList()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create Accounts");
            Console.WriteLine("2. Print all account's details");
            Console.WriteLine("3. Print details of an account");
            Console.WriteLine("4. Transact");
            Console.WriteLine("5. Print all transaction details");
        }
        static void Main(string[] args)
        {
            new Program().printMenu();
            Console.ReadKey();
        }
    }
}
