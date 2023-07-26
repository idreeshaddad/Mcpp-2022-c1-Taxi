using Abp.Taxi.Cars;
using Abp.Taxi.Drivers;
using Abp.Taxi.Passengers;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Taxi.Bookings
{
    public class Booking : AuditedAggregateRoot<int>
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime PickupTime { get; set; }
        public decimal Price { get; set; }

        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }

        public int? CarId { get; set; }
        public Car Car { get; set; }

        public int? DriverId { get; set; }
        public Driver Driver { get; set; }
    }
}
