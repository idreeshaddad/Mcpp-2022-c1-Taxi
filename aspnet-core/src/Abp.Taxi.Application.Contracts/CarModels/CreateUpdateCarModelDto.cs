using Volo.Abp.Application.Dtos;

namespace Abp.Taxi.CarModels
{
    public class CreateUpdateCarModelDto : EntityDto<int>
    {
        public string Name { get; set; }

        public int ManufacturerId { get; set; }
    }
}