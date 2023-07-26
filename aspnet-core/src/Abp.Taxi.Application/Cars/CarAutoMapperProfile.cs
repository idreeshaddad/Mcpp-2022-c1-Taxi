using AutoMapper;

namespace Abp.Taxi.Cars
{
    public class CarAutoMapperProfile : Profile
    {
        public CarAutoMapperProfile()
        {
            CreateMap<Car, CarDto>();
            CreateMap<CreateUpdateCarDto, Car>();
        }
    }
}
