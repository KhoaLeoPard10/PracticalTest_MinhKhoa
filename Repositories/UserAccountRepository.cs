using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserAccountRepository
    {
        private BookManagementDbContext _context;
        public UserAccount? GetAccount(string email, string password)
        {
            _context = new BookManagementDbContext();
            return _context.UserAccounts.FirstOrDefault(x =>  x.Email == email && x.Password == password);
        }
    }
}
