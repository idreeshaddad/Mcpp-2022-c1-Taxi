using AutoMapper;

namespace Abp.Taxi.Manufacturers
{
    public class ManufacturerAutoMapperProfile : Profile
    {
        public ManufacturerAutoMapperProfile()
        {
            CreateMap<Manufacturer, ManufacturerDto>().ReverseMap();
        }
    }
}
