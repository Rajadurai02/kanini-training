using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class SavingsAccount :Account
    {
        public SavingsAccount()
        {
            Type = "Savings";
        }

        public SavingsAccount(string accountNumber, string name, double balance, string type, string phone) : base(accountNumber, name, balance, "Savings", phone)
        {

        }

       
        public override bool Transact( string transType, double amount)
        {
            bool result = false;
            if(transType=="Credit")
            {
                if(Balance-amount >5000)
                {
                    result = true;
                    Balance = Balance - amount;
                }
            }
            return result;
        }
    }
}