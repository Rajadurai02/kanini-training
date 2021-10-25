﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WordGussingApplication.Models
{
    public partial class ScoreBoard
    {
        public string UserName { get; set; }
        public int Score { get; set; }

        public virtual UserDetail UserNameNavigation { get; set; }
    }
}
