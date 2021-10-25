using System;
using System.Collections.Generic;

#nullable disable

namespace WordGussingApplication.Models
{
    public partial class UserWord
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Word { get; set; }

        public virtual UserDetail UserNameNavigation { get; set; }
    }
}
