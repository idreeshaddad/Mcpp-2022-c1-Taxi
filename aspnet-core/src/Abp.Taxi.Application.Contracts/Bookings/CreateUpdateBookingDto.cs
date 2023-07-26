using System;
using Volo.Abp.Application.Dtos;

namespace Abp.Taxi.Bookings
{
    public class CreateUpdateBookingDto : EntityDto<int>
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime PickupTime { get; set; }
        public decimal Price { get; set; }

        public int PassengerId { get; set; }
        public int? CarId { get; set; }
        public int? DriverId { get; set; }
    }
}
