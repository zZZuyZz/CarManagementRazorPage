using BO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementService
{
    public interface IAccountRoleService
    {
        public List<AccountRole> GetAccountRoles();

    }
}
