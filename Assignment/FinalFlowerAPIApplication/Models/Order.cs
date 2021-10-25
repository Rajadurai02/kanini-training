using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalFlowerAPIApplication.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public string UserEmail { get; set; }
        public int TotalAmount { get; set; }
    }
}
