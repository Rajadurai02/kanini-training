using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalFlowerAPIApplication.Models
{
    public class FlowerOrder
    {
        [Key]
        public int ItemID { get; set; }
        public int OrderID { get; set; }
        public int FlowerID { get; set; }
        public int Qty { get; set; }

    }
}
