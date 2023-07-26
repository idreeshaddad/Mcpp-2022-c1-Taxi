using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Taxi.Bookings
{
    public interface IBookingAppService : 
        ICrudAppService<
            BookingDto, 
            int,
            PagedAndSortedResultRequestDto, 
            CreateUpdateBookingDto>
    {
    }
}
