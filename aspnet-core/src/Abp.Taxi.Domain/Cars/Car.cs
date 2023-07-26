using Abp.Taxi.CarModels;
using Abp.Taxi.enums;
using Volo.Abp.Domain.Entities;

namespace Abp.Taxi.Cars
{
    public class Car : Entity<int>
    {
        public string PlateNumber { get; set; }
        public FuelType FuelType { get; set; }

        public int CarModelId { get; set; }
        public CarModel CarModel { get; set; }
    }
}
