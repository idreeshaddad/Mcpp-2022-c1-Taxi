using Volo.Abp.Application.Dtos;

namespace Abp.Taxi.Manufacturers
{
    public class ManufacturerDto : EntityDto<int>
    {
        public string Name { get; set; }
    }
}