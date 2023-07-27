using Volo.Abp.Application.Dtos;

namespace Abp.Taxi.Passengers
{
    public class CreateUpdatePassengerDto : EntityDto<int>
    { 
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
