﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerApiApplication.Models
{
    public class UserDTO
    {
        public string UserEmail { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
        public string JwtToken { get; set; }
    }
}
