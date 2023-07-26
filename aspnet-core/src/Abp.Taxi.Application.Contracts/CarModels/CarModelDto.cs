using Volo.Abp.Application.Dtos;

namespace Abp.Taxi.CarModels
{
    public class CarModelDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string ManufacturerName { get; set; }
    }
}