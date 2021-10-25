using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBankingApplication
{
    public class CurrentAccount : Account
    {
        public CurrentAccount()
        {
            AccountType = "Current";
        }

        public CurrentAccount(string accountNumber, string name, double balance, string phone) : base(accountNumber, name, balance, phone)
        {
            AccountType = "Current";
        }
        public override bool CheckBalanceStatus(double amount)
        {
            bool result = false;
            if(Balance - amount > 1000)
            {
                Balance = Balance - amount;
                result = true;
            }
            return result;
        }
    }
}
