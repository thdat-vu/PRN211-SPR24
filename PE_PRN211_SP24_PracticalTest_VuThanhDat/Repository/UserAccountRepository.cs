using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserAccountRepository
    {
        HoangNgocTrinhContext _dbContext = new();
        public UserAccount GetAccount(string email)
        {
            UserAccount acc;
            acc = _dbContext.UserAccounts.FirstOrDefault(acc => acc.Email == email);
            return acc;
        }
    }
}
