using System;
using System.Collections.Generic;

namespace BO.Models
{
    public partial class AccountRole
    {
        public AccountRole()
        {
            Accounts = new HashSet<Account>();
        }

        public int Id { get; set; }
        public string? RoleName { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
