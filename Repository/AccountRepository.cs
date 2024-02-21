using BO.Models;
using CarManagementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementRepo
{
    public class AccountRepository : IAccountRepository
    {
        public bool AddAccount(Account account) => AccountDAO.Instance.AddAccount(account);
       
        public bool DeleteAccount(int code) => AccountDAO.Instance.DeleteAccount(code);

        public Account GetAccountById(int code) => AccountDAO.Instance.GetAccountById(code);

        public List<Account> GetAccounts() => AccountDAO.Instance.GetAccounts();

        public Account? GetRole(string email, string password) => AccountDAO.Instance?.GetRole(email, password);

        public bool UpdateAccount(Account account) => AccountDAO.Instance.UpdateAccount(account);
    }
}
