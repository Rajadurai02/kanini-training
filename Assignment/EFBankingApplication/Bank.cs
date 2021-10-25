using EFBankingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBankingApplication
{
    public class Bank
    {
        BankContext bankContext;
        public Bank()
        {
            bankContext = new BankContext();
        }
        public void Transact()
        {
            Transaction transaction = new Transaction();
            Console.WriteLine("--- Transaction ---");
            Console.WriteLine("Enter the from Account");
            transaction.FromAccount = Console.ReadLine();
            Console.WriteLine("Enter the To Account");
            transaction.ToAccount = Console.ReadLine();
            Console.WriteLine("Enter the Amount");
            transaction.Amount = Convert.ToInt32(Console.ReadLine());


        }
    }
}
