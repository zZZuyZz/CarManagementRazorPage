using BO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementDAO
{
    public class AccountDAO
    {
        private readonly CarManagementContext _db = null;
        protected static AccountDAO instance = null;
        public static AccountDAO Instance
        {
            get
            {
                //if (instance == null)
                //{
                    instance = new AccountDAO();
                //}
                return instance;
            }
        }
        public AccountDAO()
        {
            _db = new CarManagementContext();
        }
        public List<Account> GetAccounts()
        {
            return _db.Accounts.ToList();
        }

        public Account GetAccountById(int code)
        {
            return _db.Accounts.Where(x => x.Id.Equals(code)).FirstOrDefault();
        }
        public Account? GetRole(string email, string password)
        {
            var a = _db.Accounts.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
            return a;
        }
        public bool UpdateAccount(Account account)
        {
            bool result = false;
            try
            {
                var dbContext = new CarManagementContext();
                dbContext.Accounts.Update(account);
                dbContext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                return result;
            }
            return result;
        }
        public bool AddAccount(Account account)
        {
            bool result = false;
            try
            {
                var dbContext = new CarManagementContext();
                dbContext.Accounts.Add(account);
                dbContext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                return result;
            }
            return result;
        }
        public bool DeleteAccount(int code)
        {
            bool result = false;
            try
            {
                var account = GetAccountById(code);
                var dbContext = new CarManagementContext();
                dbContext.Accounts.Remove(account);
                dbContext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                return result;
            }
            return result;
        }
    }

}
