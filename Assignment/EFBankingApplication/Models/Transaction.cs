using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBankingApplication
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }
    }
}
