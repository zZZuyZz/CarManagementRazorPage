using System;
using System.Collections.Generic;

namespace BO.Models
{
    public partial class CarClass
    {
        public CarClass()
        {
            CarInformations = new HashSet<CarInformation>();
        }

        public int Id { get; set; }
        public string? ClassType { get; set; }

        public virtual ICollection<CarInformation> CarInformations { get; set; }
    }
}
