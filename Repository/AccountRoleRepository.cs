using BO.Models;
using CarManagementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementRepo
{
    public class AccountRoleRepository : IAccountRoleRepository
    {
        public List<AccountRole> GetAccountRoles() => AccountRoleDAO.Instance.GetAccountRoles();
    }
}
