using System;
using System.Collections.Generic;

namespace BO.Models
{
    public partial class Account
    {
        public Account()
        {
            CarInformations = new HashSet<CarInformation>();
        }

        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string? Tel { get; set; }
        public string? Job { get; set; }
        public string? CurrentAddress { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }

        public virtual AccountRole Role { get; set; } = null!;
        public virtual ICollection<CarInformation> CarInformations { get; set; }
    }
}
