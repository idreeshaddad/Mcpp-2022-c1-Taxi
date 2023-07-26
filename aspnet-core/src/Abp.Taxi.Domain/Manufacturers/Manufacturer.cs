using Abp.Taxi.CarModels;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Abp.Taxi.Manufacturers
{
    public class Manufacturer : Entity<int>
    {
        public string Name { get; set; }

        public List<CarModel> CarModels { get; set; }
    }
}
