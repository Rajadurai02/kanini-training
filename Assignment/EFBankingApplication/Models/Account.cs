using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBankingApplication
{
    public class Account
    {
        public string AccountType { get; set; }

        [Key]
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
       
        public string Phone { get; set; }

    }
}
