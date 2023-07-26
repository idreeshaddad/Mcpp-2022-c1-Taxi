using Abp.Taxi.enums;
using Volo.Abp.Application.Dtos;

namespace Abp.Taxi.Cars
{
    public class CarDto : EntityDto<int>
    {
        public string PlateNumber { get; set; }
        public FuelType FuelType { get; set; }

        public string CarModelName { get; set; }
    }
}
