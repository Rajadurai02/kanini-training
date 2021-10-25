using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class CurrentAccount:Account
    {
        public CurrentAccount()
        {
            Type = "Current";
        }

        public CurrentAccount(string accountNumber, string name, double balance, string type, string phone) : base(accountNumber, name, balance, "Current", phone)
        {
        }
        public override bool Transact( string transType, double amount)
        {
            bool result = false;
            if (transType == "Credit")
            {
                if (Balance - amount > 1000)
                {
                    result = true;
                    Balance = Balance - amount;
                }
            }
            return result;
        }
    }
}