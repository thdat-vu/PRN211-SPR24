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
        private HoangNgocTrinhContext _dbContext;
        //lấy 1 account thoi nên đừng có lấy list.
        public UserAccount GetAccount(string email)
        {
            _dbContext = new();
            return _dbContext.UserAccounts.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
        }
    }
}
