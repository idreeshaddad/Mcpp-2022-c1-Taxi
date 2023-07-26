using Abp.Taxi.Manufacturers;
using Volo.Abp.Domain.Entities;

namespace Abp.Taxi.CarModels
{
    public class CarModel : Entity<int>
    {
        public string Name { get; set; }

        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }  
    }
}
