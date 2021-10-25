using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalFlowerAPIApplication.Models
{
    public class User
    {
        [Key]
        public string UserEmail { get; set; }

        public string Name { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
    }
}
