using Abp.Taxi.Bookings;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Taxi.Passengers
{
    public class Passenger : AuditedAggregateRoot<int>
    {
        public Passenger()
        {
            Bookings = new List<Booking>();
        }

        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public List<Booking> Bookings { get; set; }
    }
}
