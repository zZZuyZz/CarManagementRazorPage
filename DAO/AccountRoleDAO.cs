using BO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementDAO
{
    public class AccountRoleDAO
    {
        private readonly CarManagementContext _db = null;
        protected static AccountRoleDAO instance = null;
        public static AccountRoleDAO Instance
        {
            get
            {
                //if (instance == null)
                //{
                    instance = new AccountRoleDAO();
                //}
                return instance;
            }
        }
        public AccountRoleDAO()
        {
            _db = new CarManagementContext();
        }
        public List<AccountRole> GetAccountRoles()
        {
            return _db.AccountRoles.ToList();
        }
    }
}