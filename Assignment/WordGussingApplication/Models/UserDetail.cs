using System;
using System.Collections.Generic;

#nullable disable

namespace WordGussingApplication.Models
{
    public partial class UserDetail
    {
        public UserDetail()
        {
            ScoreBoards = new HashSet<ScoreBoard>();
            UserWords = new HashSet<UserWord>();
        }

        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<ScoreBoard> ScoreBoards { get; set; }
        public virtual ICollection<UserWord> UserWords { get; set; }
    }
}
