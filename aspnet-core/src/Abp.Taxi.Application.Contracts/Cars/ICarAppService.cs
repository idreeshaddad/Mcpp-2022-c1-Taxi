using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Taxi.Cars
{
    public interface ICarAppService :
        ICrudAppService<
            CarDto,
            int,
            PagedAndSortedResultRequestDto,
            CreateUpdateCarDto>
    {
    }
}
