using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSApplication
{
    class Account
    {
        public float Balance { get; set; }
        public bool IdProof { get; set; }
        public string Name { get; set; }
        public Account()
        {
            Console.WriteLine("Default Constrcutor");
        }
        public Account(string name)
        {
            Name = name;
        }
        public void CreateAccount(float Amount)
        {
            Balance = Amount;
            IdProof = false;
        }
        public void CreateAccount(float Amount,string idProof)
        {
            Balance = Amount;
            Console.WriteLine("The ID proof is " + idProof);
            IdProof = true;
        }
        public static Account operator +(Account a1, Account a2)
        {
            Account account = new Account();
            account.Balance = a1.Balance + a2.Balance;
            return account;
        }
    }
}
