using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Taxi.Passengers
{
    public interface IPassengerAppService : 
        ICrudAppService<
            PassengerDto,
            int,
            PagedAndSortedResultRequestDto>
    {
    }
}
