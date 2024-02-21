using BO.Models;
using CarManagementRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementService
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepo = null;
        public AccountService()
        {
            accountRepo = new AccountRepository();
        }
        public bool AddAccount(Account account)
        {
            return accountRepo.AddAccount(account);
        }

        public bool DeleteAccount(int code)
        {
            return accountRepo.DeleteAccount(code);
        }

        public Account GetAccountById(int code)
        {
            return accountRepo.GetAccountById(code);
        }

        public List<Account> GetAccounts()
        {
            return accountRepo.GetAccounts();
        }

        public Account? GetRole(string email, string password)
        {
            return accountRepo.GetRole(email, password);
        }

        public bool UpdateAccount(Account account)
        {
            return accountRepo.UpdateAccount(account);
        }
    }
}
