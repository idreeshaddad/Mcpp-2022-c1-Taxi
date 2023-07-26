using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Taxi.Bookings
{
    public class BookingAppService : CrudAppService<Booking, BookingDto, int, PagedAndSortedResultRequestDto, CreateUpdateBookingDto >, IBookingAppService
    {
        public BookingAppService(IRepository<Booking, int> bookingRepository)
            : base(bookingRepository)
        {
            
        }
    }
}
