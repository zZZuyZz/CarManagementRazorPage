using System;
using System.Collections.Generic;

namespace BO.Models
{
    public partial class CarInformation
    {
        public int Id { get; set; }
        public int? BrandId { get; set; }
        public int? ClassId { get; set; }
        public string? CarDescription { get; set; }
        public int? SeatNumber { get; set; }
        public int? YearCreate { get; set; }
        public string? CarColor { get; set; }
        public int? CarStatus { get; set; }
        public decimal? CarRentingPricePerDay { get; set; }
        public int OwnerId { get; set; }
        public decimal? PriceForNormalDay { get; set; }
        public decimal? PriceForWeekend { get; set; }
        public decimal? PriceForHoliday { get; set; }
        public decimal? PricePerHour { get; set; }
        public decimal? PricePerKm { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual CarClass? Class { get; set; }
        public virtual Account Owner { get; set; } = null!;
    }
}
