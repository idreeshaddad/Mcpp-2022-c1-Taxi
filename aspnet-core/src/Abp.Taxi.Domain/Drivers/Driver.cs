using Abp.Taxi.Cars;
using Abp.Taxi.enums;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Taxi.Drivers
{
    public class Driver : AuditedEntity<int>
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }

        public int? CarId { get; set; }
        public Car Car { get; set; }
    }
}
