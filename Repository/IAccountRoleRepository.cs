using BO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementRepo
{
    public interface IAccountRoleRepository
    {
        public List<AccountRole> GetAccountRoles();

    }
}
