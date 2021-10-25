using LoginApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApplication.Services
{
    public class AccountRepo : IRepo<Account>
    {
        private readonly AccountContext _context;
        public AccountRepo(AccountContext context)
        {
            _context = context;
        }
        public Account Get(string Username)
        {
            Account account = null;
            try
            {
                account = _context.Accounts.FirstOrDefault(e => e.UserName == Username);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return account;
        }
    }
    
}
