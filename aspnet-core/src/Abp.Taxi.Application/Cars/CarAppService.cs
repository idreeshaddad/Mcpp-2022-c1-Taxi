using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Taxi.Cars
{
    public class CarAppService :
        CrudAppService<Car, CarDto, int, PagedAndSortedResultRequestDto, CreateUpdateCarDto>,
        ICarAppService
    {
        public CarAppService(IRepository<Car, int> carRepository)
            : base(carRepository)
        {

        }
    }
}
