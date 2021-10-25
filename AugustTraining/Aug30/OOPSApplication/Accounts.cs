using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSApplication
{
    public class Accounts
    {
        public int[] AccountNumber { get; set; }
        public string[] Name { get; set; }
        public float[] Balance { get; set; }
        public string[] Phone { get; set; }

        public Accounts()
        {

        }
        public  Accounts(int[] AccNo,string[] name,float[] balance,string[] phone)
        {
            AccountNumber = AccNo;
            Name = name;
            Balance = balance;
            Phone = phone;
        }
        public virtual void Transact()
        {

        }
    }
    public class savingsAccount : Accounts
    {
        public override void Transact()
        {
            foreach (float bal in ) 
        }
    }
    public class currentAccount : Accounts
    {
        public override void Transact()
        {

        }
    }
}
