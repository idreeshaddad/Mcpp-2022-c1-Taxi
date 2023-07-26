using Abp.Taxi.Bookings;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Abp.Taxi.Passengers
{
    public class PassengerDto : EntityDto<int>
    {
        public PassengerDto()
        {
            Bookings = new List<BookingDto>();
        }

        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public List<BookingDto> Bookings { get; set; }
    }
}
