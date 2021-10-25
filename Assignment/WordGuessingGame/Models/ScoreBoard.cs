using System;
using System.Collections.Generic;

#nullable disable

namespace WordGuessingGame.Models
{
    public partial class ScoreBoard
    {
        public int ScoreId { get; set; }
        public string UserName { get; set; }
        public int? Score { get; set; }

        public virtual UserDetail UserNameNavigation { get; set; }
    }
}
