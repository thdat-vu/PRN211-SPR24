using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserAccountService
    {
        UserAccountRepository _repo;
        public UserAccount CheckLogin(string email, string password)
        {
            _repo = new UserAccountRepository();
            UserAccount acc = _repo.GetAccount(email);
            if (acc == null)
            {
                return null;
            }
            else
            {
                if(acc.Password == password)
                {
                    return acc;
                }
            }
            return acc;
        }
    }
}
