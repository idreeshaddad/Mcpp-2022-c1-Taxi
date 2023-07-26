using AutoMapper;

namespace Abp.Taxi.Bookings
{
    public class BookingAutoMapperProfile : Profile
    {
        public BookingAutoMapperProfile()
        {
            CreateMap<Booking, BookingDto>();
            CreateMap<CreateUpdateBookingDto, Booking>();
        }
    }
}
