using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApplication.Services
{
    public interface IRepo<Acc>
    {
        Acc Get(string Username);
    }
}
