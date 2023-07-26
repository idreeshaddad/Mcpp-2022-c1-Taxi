using Abp.Taxi.enums;
using Volo.Abp.Application.Dtos;

namespace Abp.Taxi.Cars
{
    public class CreateUpdateCarDto : EntityDto<int>
    {
        public string PlateNumber { get; set; }
        public FuelType FuelType { get; set; }

        public int CarModelId { get; set; }
    }
}
