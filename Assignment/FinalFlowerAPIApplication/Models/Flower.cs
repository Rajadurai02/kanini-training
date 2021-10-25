using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalFlowerAPIApplication.Models
{
    public class Flower
    {
        [Key]
        public int FlowerID { get; set; }
        public string FlowerName { get; set; }
        public string FlowerDesc { get; set; }
        public int FlowerPrice { get; set; }
        public int FlowerQty { get; set; }
        public string FlowerPath { get; set; }
    }
}
