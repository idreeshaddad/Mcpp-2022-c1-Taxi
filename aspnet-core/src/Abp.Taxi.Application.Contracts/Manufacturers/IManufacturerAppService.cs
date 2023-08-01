using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Taxi.Manufacturers
{
    public interface IManufacturerAppService :
        ICrudAppService<
            ManufacturerDto,
            int,
            PagedAndSortedResultRequestDto>
    {
    }
}
