using AutoMapper;

namespace Abp.Taxi.Passengers
{
    public class PassengerAutoMapperProfile : Profile
    {
        public PassengerAutoMapperProfile()
        {
            CreateMap<Passenger, PassengerDto>().ReverseMap();
        }
    }
}
