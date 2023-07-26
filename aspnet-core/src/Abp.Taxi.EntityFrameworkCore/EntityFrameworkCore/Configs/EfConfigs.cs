using Abp.Taxi.Bookings;
using Abp.Taxi.CarModels;
using Abp.Taxi.Cars;
using Abp.Taxi.Drivers;
using Abp.Taxi.Manufacturers;
using Abp.Taxi.Passengers;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Abp.Taxi.EntityFrameworkCore.Configs
{
    internal class EfConfigs
    {
        internal static void ConfigureDomains(ModelBuilder builder)
        {
            builder.Entity<Car>(b =>
            {
                b.ToTable(TaxiConsts.DbTablePrefix + "Cars", TaxiConsts.DbSchema);
                b.ConfigureByConvention();
            });

            builder.Entity<CarModel>(b =>
            {
                b.ToTable(TaxiConsts.DbTablePrefix + "CarModels", TaxiConsts.DbSchema);
                b.ConfigureByConvention();
            });

            builder.Entity<Manufacturer>(b =>
            {
                b.ToTable(TaxiConsts.DbTablePrefix + "Manufacturers", TaxiConsts.DbSchema);
                b.ConfigureByConvention();
            });

            builder.Entity<Driver>(b =>
            {
                b.ToTable(TaxiConsts.DbTablePrefix + "Drivers", TaxiConsts.DbSchema);
                b.ConfigureByConvention();
            });

            builder.Entity<Passenger>(b =>
            {
                b.ToTable(TaxiConsts.DbTablePrefix + "Passengers", TaxiConsts.DbSchema);
                b.ConfigureByConvention();
            });

            builder.Entity<Booking>(b =>
            {
                b.ToTable(TaxiConsts.DbTablePrefix + "Bookings", TaxiConsts.DbSchema);
                b.ConfigureByConvention();

                b.Property(b => b.Price).HasPrecision(8, 2);
            });
        }
    }
}
