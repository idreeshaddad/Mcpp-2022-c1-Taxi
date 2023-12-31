﻿using Abp.Taxi.Bookings;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Abp.Taxi.Passengers
{
    public class PassengerDto : EntityDto<int>
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
