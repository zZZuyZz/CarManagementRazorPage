using BO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementRepo
{
    public interface IAccountRepository
    {
        public List<Account> GetAccounts();
        public Account GetAccountById(int code);
        public Account? GetRole(string email, string password);
        public bool AddAccount(Account account);
        public bool UpdateAccount(Account account);
        public bool DeleteAccount(int code);
    }
}
