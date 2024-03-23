using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserAccountService
    {
        private UserAccountRepository _repo = new();
        public UserAccount CheckLogin(string email, string password)
        {
            UserAccount acc = _repo.GetAccount(email);
            //có khả năng acc bằng null do user gõ sai email
            //đúng email nhưng sai pass
            if (acc != null && acc.Password == password)
            {
                return acc;
            }
            return null;
            //TODO: kiểm tra email -> nếu sai thì báo lỗi
            //kiểm tra nếu đúng email sai pass -> hiện đúng email nhưng sai pass thôi
            //0.5 còn lại là validation
        }
    }
}
