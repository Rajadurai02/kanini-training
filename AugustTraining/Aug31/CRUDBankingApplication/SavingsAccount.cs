using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBankingApplication
{
    public class SavingsAccount: Account
    {
        public SavingsAccount()
        {
            AccountType = "Savings";
        }

        public SavingsAccount(string accountNumber, string name, double balance, string phone) : base(accountNumber, name, balance, phone)
        {
            AccountType = "Savings";
        }
        public override bool CheckBalanceStatus(double amount)
        {
            bool result = false;
            if (Balance - amount > 5000)
            {
                Balance = Balance - amount;
                result = true;
            }
            return result;
        }
    }
}
