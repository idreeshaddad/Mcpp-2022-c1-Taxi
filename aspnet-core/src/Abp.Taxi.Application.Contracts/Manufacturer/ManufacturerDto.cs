using Volo.Abp.Application.Dtos;

namespace Abp.Taxi.Manufacturer
{
    public class ManufacturerDto : EntityDto<int>
    {
        public string Name { get; set; }
    }
}