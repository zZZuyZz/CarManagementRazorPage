using BO.Models;
using CarManagementRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementService
{
    public class AccountRoleService : IAccountRoleService
    {
        private readonly IAccountRoleRepository accountRoleRepo = null;
        public AccountRoleService()
        {
            accountRoleRepo = new AccountRoleRepository();
        }

        public List<AccountRole> GetAccountRoles()
        {
            return accountRoleRepo.GetAccountRoles();
        }
    }
}
