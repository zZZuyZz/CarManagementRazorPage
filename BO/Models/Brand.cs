using System;
using System.Collections.Generic;

namespace BO.Models
{
    public partial class Brand
    {
        public Brand()
        {
            CarInformations = new HashSet<CarInformation>();
        }

        public int Id { get; set; }
        public string? BrandName { get; set; }

        public virtual ICollection<CarInformation> CarInformations { get; set; }
    }
}
