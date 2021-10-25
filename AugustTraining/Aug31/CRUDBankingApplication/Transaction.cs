using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBankingApplication
{
    public class Transaction
    {
        public int Id { get; set; }
        public Account FromAccount { get; set; }
        public Account ToAccount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }

        public override string ToString()
        {
            string strAmount = "";
            if (Type == "credit")
                strAmount = "+" + Amount.ToString();
            else
                strAmount = "-" + Amount.ToString();
            return "Transaction Number : " + Id
            + "\n-------------------------------------------------\n"
            + "\nFrom Account Details : \n" + FromAccount.ToString()
            + "\n-------------------------------------------------\n"
            + "\nTo Account Details : \n" + ToAccount.ToString()
            + "\n-------------------------------------------------\n"
            + "\nTransaction Date : " + TransactionDate
            + "\nTransaction amount : " + strAmount
            + "\nTransaction status : " + Status;

        }
    }
}

