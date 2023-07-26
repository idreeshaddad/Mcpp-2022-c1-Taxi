using Abp.Taxi.Cars;
using Abp.Taxi.Drivers;
using Abp.Taxi.enums;
using Abp.Taxi.Passengers;
using System;
using Volo.Abp.Application.Dtos;

namespace Abp.Taxi.Bookings
{
    public class BookingDto : EntityDto<int>
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime PickupTime { get; set; }
        public decimal Price { get; set; }

        public string PassengerFullName { get; set; }
        public string PassengerPhoneNumber { get; set; }

        public string CarPlateNumber { get; set; }
        public FuelType CarFuelType { get; set; }

        public string DriverFullName { get; set; }
        public string DriverPhoneNumber { get; set; }
    }
}
