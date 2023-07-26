using Abp.Taxi.Cars;
using Abp.Taxi.enums;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Abp.Taxi.Drivers
{
    public class DriverDto : EntityDto<int>
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }

        public string CarModelName { get; set; }
        public string CarPlateNumber { get; set; }
    }
}
