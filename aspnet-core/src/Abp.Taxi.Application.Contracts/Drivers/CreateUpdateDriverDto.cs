using Abp.Taxi.Cars;
using Abp.Taxi.enums;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Abp.Taxi.Drivers
{
    public class CreateUpdateDriverDto : EntityDto<int>
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }

        public int? CarId { get; set; }
    }
}
